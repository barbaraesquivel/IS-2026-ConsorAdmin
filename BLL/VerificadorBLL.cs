using BE;
using DAL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class VerificadorBLL
    {
        private readonly ConsorcioDAL _consorcioDAL = new();
        private readonly VerificadorVerticalDAL _vvDAL = new();
        private readonly ILogBitacoraBLL _log = new LogBitacoraBLL();

        private const string TablaConsorcio = "CONSORCIO";

        // Verifica DVH de cada consorcio y el DVV de la tabla.
        // Si VERIFICADOR_VERTICAL no tiene fila para CONSORCIO, retorna Inicializado=false.
        public ResultadoVerificacion VerificarIntegridad()
        {
            var resultado = new ResultadoVerificacion();

            var vv = _vvDAL.ObtenerPorTabla(TablaConsorcio);
            if (vv == null)
            {
                resultado.Inicializado = false;
                return resultado;
            }
            resultado.Inicializado = true;

            var consorcios = _consorcioDAL.ObtenerTodosConUnidades();

            foreach (var c in consorcios)
            {
                int dvhCalculado = CalculadoraDV.CalcularDVH(c);
                if (dvhCalculado != c.DVH)
                    resultado.FilasConDvhInvalido.Add(c.ObtenerIdentificador());
            }

            // DVV se recalcula sobre los DVH ALMACENADOS: detecta filas agregadas/borradas
            int dvvCalculado = CalculadoraDV.CalcularDVV(consorcios);
            resultado.DvvInvalido = dvvCalculado != vv.DVV;

            if (!resultado.Ok)
            {
                _log.Registrar(Guid.Empty, AccionesBitacora.VerificacionDV, ModulosBitacora.Integridad,
                    $"Integridad comprometida. Filas DVH inválido: [{string.Join(", ", resultado.FilasConDvhInvalido)}]. " +
                    $"DVV inválido: {resultado.DvvInvalido}");
            }

            return resultado;
        }

        // Línea base: recalcula y persiste DVH/DVV, y guarda un backup del estado íntegro.
        // Es el ÚNICO punto donde se genera un backup; nunca se llama automáticamente al arrancar
        // ni durante una alteración detectada.
        public void GenerarDigitos()
        {
            var consorcios = _consorcioDAL.ObtenerTodosConUnidades();

            foreach (var c in consorcios)
            {
                int dvh = CalculadoraDV.CalcularDVH(c);
                c.DVH = dvh;
                _consorcioDAL.ActualizarDvh(c.Id_Consorcio, dvh);
            }

            int dvv = CalculadoraDV.CalcularDVV(consorcios);
            _vvDAL.GuardarOActualizar(TablaConsorcio, dvv);

            string nombreArchivo = ServicioBackupConsorcio.GuardarCopiaSeguridad(consorcios);

            _log.Registrar(Guid.Empty, AccionesBitacora.GenerarDigitos, ModulosBitacora.Integridad,
                $"Dígitos generados para {consorcios.Count} consorcio(s). Backup: {nombreArchivo}");
        }

        // Recalcula el DVH del consorcio indicado y luego actualiza el DVV de la tabla.
        // Llamar después de cualquier CRUD sobre Consorcio o Unidad.
        public void RecalcularYGuardarDvhConsorcio(string idConsorcio)
        {
            var consorcio = _consorcioDAL.ObtenerPorId(idConsorcio);
            if (consorcio == null) return;

            int dvh = CalculadoraDV.CalcularDVH(consorcio);
            _consorcioDAL.ActualizarDvh(idConsorcio, dvh);

            RecalcularYGuardarDvv();
        }

        // Recalcula el DVV a partir de los DVH almacenados actuales.
        // Llamar después de eliminar un consorcio (el DVH de esa fila ya no existe).
        public void RecalcularYGuardarDvv()
        {
            var todosDvh = _consorcioDAL.ObtenerTodosDvh();
            int dvv = (int)(todosDvh.Sum(d => (long)d) % 9973);
            _vvDAL.GuardarOActualizar(TablaConsorcio, dvv);
        }

        // Compara el estado actual de la BD contra el último backup.
        // Retorna null si no hay backup. Retorna lista vacía si no hay diferencias.
        // Contempla tres casos: Modificada, Faltante y Sobrante.
        public List<DiferenciaDV>? CompararConBackup(Guid idAdmin)
        {
            if (!ServicioBackupConsorcio.ExisteCopiaSeguridad())
                return null;

            var backups = ServicioBackupConsorcio.CargarUltimaCopiaSeguridad()!;
            var actuales = _consorcioDAL.ObtenerTodos();

            var backupDict = backups.ToDictionary(c => c.Id_Consorcio);
            var actualDict = actuales.ToDictionary(c => c.Id_Consorcio);
            var diferencias = new List<DiferenciaDV>();

            // MODIFICADAS y FALTANTES: iterar sobre backup
            foreach (var (id, bk) in backupDict)
            {
                if (actualDict.TryGetValue(id, out var ac))
                {
                    AgregarSiDistinto(diferencias, id, "Nombre",          bk.Nombre,              ac.Nombre);
                    AgregarSiDistinto(diferencias, id, "Dirección",       bk.Direccion,           ac.Direccion);
                    AgregarSiDistinto(diferencias, id, "Cant. unidades",  bk.CantUnidades.ToString(), ac.CantUnidades.ToString());
                }
                else
                {
                    // La fila del backup no existe en la BD: fue borrada por fuera del sistema
                    diferencias.Add(new DiferenciaDV
                    {
                        IdConsorcio    = id,
                        Campo          = "(fila completa)",
                        ValorBackup    = bk.Nombre,
                        ValorActual    = "-",
                        TipoDiferencia = TipoDiferenciaDV.Faltante
                    });
                }
            }

            // SOBRANTES: filas en BD que no estaban en el backup → fueron agregadas por fuera
            foreach (var (id, ac) in actualDict)
            {
                if (!backupDict.ContainsKey(id))
                    diferencias.Add(new DiferenciaDV
                    {
                        IdConsorcio    = id,
                        Campo          = "(fila completa)",
                        ValorBackup    = "-",
                        ValorActual    = ac.Nombre,
                        TipoDiferencia = TipoDiferenciaDV.Sobrante
                    });
            }

            _log.Registrar(idAdmin, AccionesBitacora.ConsultarDetalleIntegridad, ModulosBitacora.Integridad,
                $"Admin consultó detalle de alteraciones. Diferencias encontradas: {diferencias.Count}");

            return diferencias;
        }

        public ResultadoRestauracion RestaurarDesdeBackup(Guid idAdmin)
        {
            if (!ServicioBackupConsorcio.ExisteCopiaSeguridad())
                throw new Exception("No hay backup disponible para restaurar.");

            var backups = ServicioBackupConsorcio.CargarUltimaCopiaSeguridad()!;
            var actuales = _consorcioDAL.ObtenerTodos();

            var backupDict = backups.ToDictionary(c => c.Id_Consorcio);
            var actualDict = actuales.ToDictionary(c => c.Id_Consorcio);

            var resultado = new ResultadoRestauracion();

            // MODIFICADAS y FALTANTES: iterar sobre backup
            foreach (var bk in backups)
            {
                if (actualDict.ContainsKey(bk.Id_Consorcio))
                {
                    _consorcioDAL.RestaurarCampos(
                        bk.Id_Consorcio, bk.Nombre, bk.Direccion, bk.CantUnidades);
                    resultado.Actualizadas++;
                }
                else
                {
                    try
                    {
                        _consorcioDAL.Crear(bk);
                        resultado.Insertadas++;
                    }
                    catch (Exception ex)
                    {
                        resultado.Errores.Add($"No se pudo insertar '{bk.Nombre}' ({bk.Id_Consorcio}): {ex.Message}");
                    }
                }
            }

            // SOBRANTES: filas en BD que no están en el backup
            foreach (var ac in actuales)
            {
                if (!backupDict.ContainsKey(ac.Id_Consorcio))
                {
                    try
                    {
                        _consorcioDAL.Eliminar(ac);
                        resultado.Eliminadas++;
                    }
                    catch (Exception ex)
                    {
                        resultado.Errores.Add($"No se pudo eliminar '{ac.Nombre}' ({ac.Id_Consorcio})" +
                            $" — tiene registros dependientes; eliminalos manualmente: {ex.Message}");
                    }
                }
            }

            if (resultado.Errores.Count == 0)
                GenerarDigitos();
            else
                RecalcularDvhYDvvSinBackup();

            _log.Registrar(idAdmin, AccionesBitacora.RestaurarBackup, ModulosBitacora.Integridad,
                $"Restauración desde backup: {resultado.Actualizadas} actualizadas, {resultado.Insertadas} insertadas, " +
                $"{resultado.Eliminadas} eliminadas, {resultado.Errores.Count} error(es).");

            return resultado;
        }

        // Recalcula DVH/DVV en la BD sin tocar el archivo de backup.
        // Usar cuando la restauración fue parcial: las filas presentes quedan íntegras
        // matemáticamente, pero el backup anterior se preserva como referencia de lo que falta.
        private void RecalcularDvhYDvvSinBackup()
        {
            var consorcios = _consorcioDAL.ObtenerTodosConUnidades();
            foreach (var c in consorcios)
            {
                int dvh = CalculadoraDV.CalcularDVH(c);
                _consorcioDAL.ActualizarDvh(c.Id_Consorcio, dvh);
            }
            var todosDvh = _consorcioDAL.ObtenerTodosDvh();
            int dvv = (int)(todosDvh.Sum(d => (long)d) % 9973);
            _vvDAL.GuardarOActualizar(TablaConsorcio, dvv);
        }

        private static void AgregarSiDistinto(List<DiferenciaDV> lista, string id, string campo, string bk, string ac)
        {
            if (bk != ac)
                lista.Add(new DiferenciaDV
                {
                    IdConsorcio    = id,
                    Campo          = campo,
                    ValorBackup    = bk,
                    ValorActual    = ac,
                    TipoDiferencia = TipoDiferenciaDV.Modificada
                });
        }
    }
}
