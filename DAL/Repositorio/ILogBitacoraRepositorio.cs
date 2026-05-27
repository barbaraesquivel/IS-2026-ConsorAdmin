using BE;
using System;
using System.Collections.Generic;

namespace DAL.Repositorio
{
    public interface ILogBitacoraRepositorio
    {
        void Registrar(LogBitacoraBE log);
        List<LogBitacoraBE> Buscar(FiltroBitacoraBE filtro);
        List<string> ObtenerModulosUnicos();
        List<string> ObtenerAccionesUnicas();
        List<(string IdUsuario, string Username)> ObtenerUsuariosConLogs();
    }
}
