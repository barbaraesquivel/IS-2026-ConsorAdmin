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
            var arbolUsuario = ObtenerArbolDeUsuario(idUsuario);

            var arbolCompleto = _repo.ObtenerArbolCompleto();
            var familia = BuscarPorCodigo(arbolCompleto, codigoFamilia);
            if (familia == null) return false;

            var patentesHijas = ObtenerPatentesHijas(familia);
            return patentesHijas.Any(p => TienePatente(idUsuario, p.Codigo));
        }

        public List<ComponentePermisoBE> ObtenerArbolCompleto() => _repo.ObtenerArbolCompleto();

        public void CrearFamilia(string codigo, string nombre)
        {
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Código y nombre son obligatorios.");
            _repo.CrearPermiso(codigo.Trim(), nombre.Trim(), "F");
        }

        public void AgregarPatenteAFamilia(int idFamilia, int idPatente)
        {
            var arbol = _repo.ObtenerArbolCompleto();
            var familia = BuscarPorId(arbol, idFamilia) as FamiliaBE;
            if (familia == null) throw new Exception("Familia no encontrada.");
            var patente = BuscarPorId(arbol, idPatente);
            if (patente == null) throw new Exception("Patente no encontrada.");
            familia.AgregarPermiso(patente);
            _repo.AgregarHijo(idFamilia, idPatente);
        }

        // ── Helpers privados ────────────────────────────────────────────────

        private ComponentePermisoBE BuscarPorId(IEnumerable<IPermiso> nodos, int id)
        {
            foreach (var nodo in nodos)
            {
                if (nodo.Id_Permiso == id) return (ComponentePermisoBE)nodo;
                var encontrado = BuscarPorId(nodo.ObtenerHijos, id);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        private ComponentePermisoBE BuscarPorCodigo(IEnumerable<IPermiso> nodos, string codigo)
        {
            foreach (var nodo in nodos)
            {
                if (nodo is ComponentePermisoBE be && be.Codigo == codigo) return be;
                var encontrado = BuscarPorCodigo(nodo.ObtenerHijos, codigo);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        private bool ContienePatenteCodigo(IEnumerable<IPermiso> nodos, string codigo)
        {
            foreach (var nodo in nodos)
            {
                if (nodo is PatenteBE p && p.Codigo == codigo) return true;
                if (ContienePatenteCodigo(nodo.ObtenerHijos, codigo)) return true;
            }
            return false;
        }

        private List<PatenteBE> ObtenerPatentesHijas(IPermiso nodo)
        {
            var resultado = new List<PatenteBE>();
            foreach (var hijo in nodo.ObtenerHijos)
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
