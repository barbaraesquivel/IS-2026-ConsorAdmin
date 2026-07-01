using BE;
using DAL.Repositorio;
using SERV;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class LogBitacoraBLL : ILogBitacoraBLL
    {
        private readonly ILogBitacoraRepositorio _repo = new LogBitacoraRepositorio();

        public void Registrar(Guid idUsuario, string accion, string modulo, string detalle)
        {
            try
            {
                _repo.Registrar(new LogBitacoraBE
                {
                    Id_Usuario = idUsuario,
                    FechaHora = DateTime.Now,
                    Accion = accion,
                    Modulo = modulo,
                    Detalle = detalle
                });
            }
            catch { }
        }

        public void Registrar(string accion, string modulo, string detalle)
        {
            var idUsuario = SessionManager.SesionActiva()
                ? SessionManager.ObtenerInstancia.Usuario.Id
                : Guid.Empty;
            Registrar(idUsuario, accion, modulo, detalle);
        }

        public List<LogBitacoraBE> Consultar(FiltroBitacoraBE filtro)
        {
            if (filtro.FechaDesde.HasValue && filtro.FechaHasta.HasValue)
            {
                if (filtro.FechaDesde.Value > filtro.FechaHasta.Value)
                    throw new Exception("La fecha desde debe ser anterior a la fecha hasta.");

                if ((filtro.FechaHasta.Value - filtro.FechaDesde.Value).TotalDays > 90)
                    throw new Exception("El rango no puede superar los 90 días.");
            }

            return _repo.Buscar(filtro);
        }

        public List<string> ObtenerModulos() => _repo.ObtenerModulosUnicos();
        public List<string> ObtenerAcciones() => _repo.ObtenerAccionesUnicas();
        public List<(string IdUsuario, string Username)> ObtenerUsuariosConLogs() => _repo.ObtenerUsuariosConLogs();

        public void RegistrarExportacion(Guid idUsuario, int cantidadRegistros)
        {
            Registrar(idUsuario, AccionesBitacora.ExportarBitacora, ModulosBitacora.Seguridad,
                $"Exportación de bitácora: {cantidadRegistros} registros");
        }
    }
}
