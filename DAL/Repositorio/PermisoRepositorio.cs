using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositorio
{
    public class PermisoRepositorio
    {
        public List<ComponentePermisoBE> ObtenerArbolCompleto()
        {
            using var ctx = new AppDbContext();

            var permisos = ctx.Permisos.ToList();
            var relaciones = ctx.PermisoPermisos.ToList();

            var nodos = new Dictionary<int, ComponentePermisoBE>();
            foreach (var p in permisos)
            {
                ComponentePermisoBE nodo = p.Tipo == "F"
                    ? new FamiliaBE { Id_Permiso = p.IdPermiso, Codigo = p.Codigo, Nombre = p.Nombre, Tipo = p.Tipo }
                    : new PatenteBE { Id_Permiso = p.IdPermiso, Codigo = p.Codigo, Nombre = p.Nombre, Tipo = p.Tipo };
                nodos[p.IdPermiso] = nodo;
            }

            var tienenPadre = new HashSet<int>();
            foreach (var rel in relaciones)
            {
                if (nodos.TryGetValue(rel.IdPadre, out var padre) && nodos.TryGetValue(rel.IdHijo, out var hijo))
                {
                    padre.Agregar(hijo);
                    tienenPadre.Add(rel.IdHijo);
                }
            }

            return nodos.Values
                .Where(n => !tienenPadre.Contains(n.Id_Permiso))
                .OrderBy(n => n.Tipo)
                .ThenBy(n => n.Codigo)
                .ToList();
        }

        public List<int> ObtenerPermisosDeUsuario(Guid idUsuario)
        {
            using var ctx = new AppDbContext();
            return ctx.UsuarioPermisos
                .Where(up => up.IdUsuario == idUsuario)
                .Select(up => up.IdPermiso)
                .ToList();
        }
    }
}
