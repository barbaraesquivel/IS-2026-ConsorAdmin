using BE;
using DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class PermisoBLL : IPermisoBLL
    {
        private readonly PermisoRepositorio _repo = new PermisoRepositorio();

        /// <summary>
        /// Expande los permisos asignados al usuario: si se asignó una Familia,
        /// se incluye completa (con todos sus hijos transitivos).
        /// </summary>
        public List<ComponentePermisoBE> ObtenerArbolDeUsuario(Guid idUsuario)
        {
            var arbolCompleto = _repo.ObtenerArbolCompleto();
            var idsAsignados = _repo.ObtenerPermisosDeUsuario(idUsuario);

            var resultado = new List<ComponentePermisoBE>();
            foreach (var id in idsAsignados)
            {
                var comp = BuscarPorId(arbolCompleto, id);
                if (comp != null && resultado.All(r => r.Id_Permiso != comp.Id_Permiso))
                    resultado.Add(comp);
            }
            return resultado;
        }

        public bool TienePatente(Guid idUsuario, string codigoPatente)
        {
            var arbol = ObtenerArbolDeUsuario(idUsuario);
            return ContienePatenteCodigo(arbol, codigoPatente);
        }

        public bool TieneAlgunaPatenteDeFamilia(Guid idUsuario, string codigoFamilia)
        {
            var arbolCompleto = _repo.ObtenerArbolCompleto();
            var familia = BuscarPorCodigo(arbolCompleto, codigoFamilia);
            if (familia == null) return false;

            var patentesHijas = ObtenerPatentesHijas(familia);
            return patentesHijas.Any(p => TienePatente(idUsuario, p.Codigo));
        }

        // ── Helpers privados ────────────────────────────────────────────────

        private ComponentePermisoBE BuscarPorId(List<ComponentePermisoBE> nodos, int id)
        {
            foreach (var nodo in nodos)
            {
                if (nodo.Id_Permiso == id) return nodo;
                var encontrado = BuscarPorId(nodo.ObtenerHijos(), id);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        private ComponentePermisoBE BuscarPorCodigo(List<ComponentePermisoBE> nodos, string codigo)
        {
            foreach (var nodo in nodos)
            {
                if (nodo.Codigo == codigo) return nodo;
                var encontrado = BuscarPorCodigo(nodo.ObtenerHijos(), codigo);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        private bool ContienePatenteCodigo(List<ComponentePermisoBE> nodos, string codigo)
        {
            foreach (var nodo in nodos)
            {
                if (nodo is PatenteBE && nodo.Codigo == codigo) return true;
                if (ContienePatenteCodigo(nodo.ObtenerHijos(), codigo)) return true;
            }
            return false;
        }

        // Recorre recursivamente y recoge todas las PatenteBE del subárbol
        private List<PatenteBE> ObtenerPatentesHijas(ComponentePermisoBE nodo)
        {
            var resultado = new List<PatenteBE>();
            foreach (var hijo in nodo.ObtenerHijos())
            {
                if (hijo is PatenteBE p)
                    resultado.Add(p);
                else
                    resultado.AddRange(ObtenerPatentesHijas(hijo));
            }
            return resultado;
        }
    }
}
