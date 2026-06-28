using BE;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
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
                    padre.AgregarPermiso(hijo);
                    tienenPadre.Add(rel.IdHijo);
                }
            }

            // Raíces del árbol: todas las familias [F] (con o sin padre) +
            // las patentes [P] que no están dentro de ninguna familia.
            return nodos.Values
                .Where(n => n.Tipo == "F" || !tienenPadre.Contains(n.Id_Permiso))
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

        public int CrearPermiso(string codigo, string nombre, string tipo)
        {
            using var ctx = new AppDbContext();
            var p = new Permiso { Codigo = codigo, Nombre = nombre, Tipo = tipo };
            ctx.Permisos.Add(p);
            ctx.SaveChanges();
            return p.IdPermiso;
        }

        // Devuelve TODAS las familias de la BD, sin filtrar por padre.
        // Usado para llenar combos donde se necesitan todas las opciones disponibles.
        public List<ComponentePermisoBE> ObtenerTodasLasFamilias()
        {
            using var ctx = new AppDbContext();
            return ctx.Permisos
                .Where(p => p.Tipo == "F")
                .OrderBy(p => p.Codigo)
                .ToList()
                .Select(p => (ComponentePermisoBE)new FamiliaBE
                {
                    Id_Permiso = p.IdPermiso,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Tipo = p.Tipo
                })
                .ToList();
        }

        // Devuelve TODAS las patentes de la BD, sin filtrar por padre.
        public List<ComponentePermisoBE> ObtenerTodasLasPatentes()
        {
            using var ctx = new AppDbContext();
            return ctx.Permisos
                .Where(p => p.Tipo == "P")
                .OrderBy(p => p.Codigo)
                .ToList()
                .Select(p => (ComponentePermisoBE)new PatenteBE
                {
                    Id_Permiso = p.IdPermiso,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Tipo = p.Tipo
                })
                .ToList();
        }

        public void AgregarHijo(int idPadre, int idHijo)
        {
            using var ctx = new AppDbContext();
            ctx.Database.ExecuteSqlRaw(
                "INSERT INTO PERMISO_PERMISO (id_padre, id_hijo) VALUES ({0}, {1})", idPadre, idHijo);
        }
    }
}
