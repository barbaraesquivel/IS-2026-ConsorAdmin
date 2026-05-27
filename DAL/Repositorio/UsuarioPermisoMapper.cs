using BE;
using DAL.Models;
using System;

namespace DAL.Repositorio
{
    public static class UsuarioPermisoMapper
    {
        // EF → BE
        public static UsuarioPermisoBE Map(UsuarioPermiso usuarioPermiso)
        {
            return new UsuarioPermisoBE()
            {
                Id_Usuario_Permiso = usuarioPermiso.IdUsuarioPermiso.ToString(),
                Id_Permiso = usuarioPermiso.IdPermiso.ToString(),
                Id_Usuario = usuarioPermiso.IdUsuario.ToString(),

                permisoBE = usuarioPermiso.IdPermisoNavigation != null
                    ? PermisoMapper.Map(usuarioPermiso.IdPermisoNavigation)
                    : null,

                usuarioBE = null   // no llamar UsuarioMapper: evita ciclo UsuarioPermiso ↔ Usuario
            };
        }

        // BE → EF (IdUsuarioPermiso not set — IDENTITY column, DB generates it)
        public static UsuarioPermiso Map(UsuarioPermisoBE usuarioPermisoBE)
        {
            return new UsuarioPermiso()
            {
                IdPermiso = usuarioPermisoBE.permisoBE != null
                    ? usuarioPermisoBE.permisoBE.Id_Permiso
                    : int.Parse(usuarioPermisoBE.Id_Permiso ?? "0"),
                IdUsuario = Guid.Parse(usuarioPermisoBE.usuarioBE?.Id.ToString() ?? usuarioPermisoBE.Id_Usuario)
            };
        }
    }
}
