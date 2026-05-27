using BE;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositorio
{
    public class UsuarioMapper
    {
        // EF → Entity
        public static UsuarioBE Map(Usuario usuario)
        {
            if (usuario == null) return null;

            return new UsuarioBE()
            {
                Id = usuario.IdUsuario,
                Usuario = usuario.Username,
                Contraseña = usuario.PasswordHash,
                Bloqueado = usuario.Bloqueado,
                // Activo=true en BD significa usuario activo → Baja debe ser false
                Baja = !usuario.Activo,

                
                consorcistaBE = null!,  // no llamar ConsorcistaMapper: evita ciclo Usuario ↔ Consorcista
                proovedorBE = usuario.Proveedor != null
                    ? ProovedorMapper.Map(usuario.Proveedor)
                    : null,
                logBitacoras = usuario.LogBitacoras
                    .Select(LogBitacoraMapper.Map)
                    .ToList(),
                usuarioPermisos = usuario.UsuarioPermisos
                    .Select(UsuarioPermisoMapper.Map)
                    .ToList(),
                gestorConsorcioBEs = usuario.GestorConsorcios
                    .Select(GestorConsorcioMapper.Map)
                    .ToList()
            };
        }

        // Entity → EF
        public static Usuario Map(UsuarioBE usuarioBE)
        {
            if (usuarioBE == null) return null;

            return new Usuario()
            {
                IdUsuario = usuarioBE.Id,
                Username = usuarioBE.Usuario,
                PasswordHash = usuarioBE.Contraseña,
                Bloqueado = usuarioBE.Bloqueado,
                Activo = !usuarioBE.Baja,
                LogBitacoras = usuarioBE.logBitacoras?
                    .Select(LogBitacoraMapper.Map)
                    .ToList() ?? new List<LogBitacora>(),
                UsuarioPermisos = usuarioBE.usuarioPermisos?
                    .Select(UsuarioPermisoMapper.Map)
                    .ToList() ?? new List<UsuarioPermiso>(),
                GestorConsorcios = usuarioBE.gestorConsorcioBEs
                    .Select(GestorConsorcioMapper.Map)
                    .ToList()
            };
        }
    }
}
