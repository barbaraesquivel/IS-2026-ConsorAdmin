using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public static class UsuarioPermisoMapper
    {
        // EF → Entity
        public static UsuarioPermisoBE Map(UsuarioPermiso usuarioPermiso)
        {
            return new UsuarioPermisoBE()
            {
                Id_Usuario_Permiso = usuarioPermiso.IdUsuarioPermiso,


                Id_Permiso = usuarioPermiso.IdPermiso,
                Id_Usuario = usuarioPermiso.IdUsuario.ToString(),
                

                permisoBE = usuarioPermiso.IdPermisoNavigation != null
                    ? PermisoMapper.Map(usuarioPermiso.IdPermisoNavigation)
                    : null,

                usuarioBE = usuarioPermiso.IdUsuarioNavigation != null
                    ? UsuarioMapper.Map(usuarioPermiso.IdUsuarioNavigation)
                    : null
            };
        }

        // Entity → EF
        public static UsuarioPermiso Map(UsuarioPermisoBE usuarioPermisoBE)
        {
            return new UsuarioPermiso()
            {
                IdUsuarioPermiso = usuarioPermisoBE.Id_Usuario_Permiso.ToString(),
                IdPermiso = usuarioPermisoBE.permisoBE?.Id_Permiso.ToString(),
                IdUsuario = usuarioPermisoBE.usuarioBE?.Id.ToString()

            };
        }
    }
}
