using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class LogBitacoraMapper
    {
        
        // EF → Entity
        public static LogBitacoraBE Map(LogBitacora logBitacora)
        {
            return new LogBitacoraBE()
            {
                Id_Log = logBitacora.IdLog,
                Id_Usuario = logBitacora.IdUsuario,
                FechaHora = logBitacora.FechaHora,
                Accion = logBitacora.Accion,
                Modulo = logBitacora.Modulo,
                Detalle = logBitacora.Detalle,

                usuarioBE = logBitacora.IdUsuarioNavigation != null
                    ? UsuarioMapper.Map(logBitacora.IdUsuarioNavigation)
                    : null
            };
        }

        // Entity → EF
        public static LogBitacora Map(LogBitacoraBE logBitacoraBE)
        {
            return new LogBitacora()
            {
                IdLog = logBitacoraBE.Id_Log,
                IdUsuario = logBitacoraBE.usuarioBE != null
                    ? logBitacoraBE.usuarioBE.Id
                    : logBitacoraBE.Id_Usuario,
                FechaHora = logBitacoraBE.FechaHora,
                Accion = logBitacoraBE.Accion,
                Modulo = logBitacoraBE.Modulo,
                Detalle = logBitacoraBE.Detalle
            };
        }
        
    }
}
