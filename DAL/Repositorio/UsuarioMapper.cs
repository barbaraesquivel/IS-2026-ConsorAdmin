using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Baja = usuario.Activo,

                consorcistaBE = usuario.Consorcistum != null
                    ? ConsorcistaMapper.Map(usuario.Consorcistum)
                    : null,
                proovedorBE = usuario.Proveedor != null
                    ? ProovedorMapper.Map(usuario.Proveedor)
                    : null,
                logBitacoras = usuario.LogBitacoras
                    .Select(LogBitacoraMapper.Map)
                    .ToList(),
                usuarioPermisos = usuario.UsuarioPermisos
                    .Select(UsuarioPermisoMapper.Map)
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
                Activo = usuarioBE.Baja,
                LogBitacoras = usuarioBE.logBitacoras
                    .Select(LogBitacoraMapper.Map)
                    .ToList(),
                UsuarioPermisos = usuarioBE.usuarioPermisos
                    .Select(UsuarioPermisoMapper.Map)
                    .ToList()
            };
        }
    }
}
