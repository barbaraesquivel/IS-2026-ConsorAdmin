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
                    resultado.FilasConDvhInvalido.Add(c.GetIdentificador());
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

            string nombreBackup = BackupConsorcioService.GuardarBackup(consorcios);

            _log.Registrar(Guid.Empty, AccionesBitacora.GenerarDigitos, ModulosBitacora.Integridad,
                $"Dígitos generados para {consorcios.Count} consorcio(s). Backup: {nombreBackup}");
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
            if (!BackupConsorcioService.ExisteBackup())
                return null;

            var backups  = BackupConsorcioService.CargarUltimoBackup()!;
            var actuales = _consorcioDAL.ObtenerTodos();

            var backupDict  = backups.ToDictionary(c => c.Id_Consorcio);
            var actualDict  = actuales.ToDictionary(c => c.Id_Consorcio);
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

        // Deja la tabla CONSORCIO exactamente igual al último backup, cubriendo los 3 casos:
        //   MODIFICADA  → UPDATE de campos con valores del backup
        //   FALTANTE    → INSERT de la fila que fue borrada por fuera del sistema
        //   SOBRANTE    → DELETE de la fila que fue agregada por fuera del sistema
        //                 (puede fallar si tiene registros hijos con FK NO ACTION)
        // Nota: se usa UPDATE/INSERT/DELETE por PK porque todas las FK de UNIDAD, SERVICIO
        // y GESTOR_CONSORCIO tienen ON DELETE NO ACTION; borrar e insertar masivamente
        // rompería las referencias de las filas hijas.
        public (int actualizadas, int insertadas, int eliminadas, List<string> errores)
            RestaurarDesdeBackup(Guid idAdmin)
        {
            if (!BackupConsorcioService.ExisteBackup())
                throw new Exception("No hay backup disponible para restaurar.");

            var backups   = BackupConsorcioService.CargarUltimoBackup()!;
            var actuales  = _consorcioDAL.ObtenerTodos();

            var backupDict = backups.ToDictionary(c => c.Id_Consorcio);
            var actualDict = actuales.ToDictionary(c => c.Id_Consorcio);

            int actualizadas = 0, insertadas = 0, eliminadas = 0;
            var errores = new List<string>();

            // MODIFICADAS y FALTANTES: iterar sobre backup
            foreach (var bk in backups)
            {
                if (actualDict.ContainsKey(bk.Id_Consorcio))
                {
                    // Fila presente en ambos → UPDATE campos con valores del backup
                    _consorcioDAL.RestaurarCampos(
                        bk.Id_Consorcio, bk.Nombre, bk.Direccion, bk.CantUnidades);
                    actualizadas++;
                }
                else
                {
                    // Fila en backup pero no en BD → INSERT (recupera fila borrada)
                    try
                    {
                        _consorcioDAL.Crear(bk);
                        insertadas++;
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"No se pudo insertar '{bk.Nombre}' ({bk.Id_Consorcio}): {ex.Message}");
                    }
                }
            }

            // SOBRANTES: iterar sobre BD buscando filas que no están en el backup → DELETE
            foreach (var ac in actuales)
            {
                if (!backupDict.ContainsKey(ac.Id_Consorcio))
                {
                    try
                    {
                        _consorcioDAL.Eliminar(ac);
                        eliminadas++;
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"No se pudo eliminar '{ac.Nombre}' ({ac.Id_Consorcio})" +
                            $" — tiene registros dependientes; eliminalos manualmente: {ex.Message}");
                    }
                }
            }

            if (errores.Count == 0)
            {
                // Restauración completa: el estado es íntegro → genera nuevo backup como punto
                // de restauración válido y actualiza DVH/DVV en BD.
                GenerarDigitos();
            }
            else
            {
                // Restauración parcial: preservar el backup anterior intacto (sigue siendo la
                // referencia para reintentar las operaciones fallidas). Solo actualizar DVH/DVV
                // en BD para que las filas correctamente restauradas pasen la verificación.
                RecalcularDvhYDvvSinBackup();
            }

            _log.Registrar(idAdmin, AccionesBitacora.RestaurarBackup, ModulosBitacora.Integridad,
                $"Restauración desde backup: {actualizadas} actualizadas, {insertadas} insertadas, " +
                $"{eliminadas} eliminadas, {errores.Count} error(es). " +
                $"Backup {(errores.Count == 0 ? "actualizado" : "preservado sin cambios")}.");

            return (actualizadas, insertadas, eliminadas, errores);
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
