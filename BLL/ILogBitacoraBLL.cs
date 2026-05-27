using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public interface ILogBitacoraBLL
    {
        void Registrar(Guid idUsuario, string accion, string modulo, string detalle);
        void Registrar(string accion, string modulo, string detalle);
        List<LogBitacoraBE> Consultar(FiltroBitacoraBE filtro);
        List<string> ObtenerModulos();
        List<string> ObtenerAcciones();
        List<(string IdUsuario, string Username)> ObtenerUsuariosConLogs();
        void RegistrarExportacion(Guid idUsuario, int cantidadRegistros);
    }
}
