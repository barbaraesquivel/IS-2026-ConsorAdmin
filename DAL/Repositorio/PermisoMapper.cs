using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class PermisoMapper
    {
        
        // EF → Entity
        public static PermisoBE Map(Permiso permiso)
        {
            return new PermisoBE()
            {
                Id_Permiso = permiso.IdPermiso,
                Codigo = permiso.Codigo,
                Nombre = permiso.Nombre,
                Tipo = permiso.Tipo,
                usuarioPermisos = new List<UsuarioPermisoBE>()  // no llamar UsuarioPermisoMapper: evita ciclo Permiso ↔ UsuarioPermiso
            };
        }

        // Entity → EF
        public static Permiso Map(PermisoBE permisoBE)
        {
            return new Permiso()
            {
                IdPermiso = permisoBE.Id_Permiso,
                Codigo = permisoBE.Codigo,
                Nombre = permisoBE.Nombre,
                Tipo = permisoBE.Tipo,
                UsuarioPermisos = permisoBE.usuarioPermisos
                    .Select(UsuarioPermisoMapper.Map)
                    .ToList()
            };
        }
        
    }
}
