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

        public List<ComponentePermisoBE> ObtenerArbolCompleto() => _repo.ObtenerArbolCompleto();

        public void CrearFamilia(string codigo, string nombre)
        {
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Código y nombre son obligatorios.");
            int nivelNuevo = _repo.ObtenerMaxNivelJerarquiaFamilias() + 1;
            if (nivelNuevo < 1)
                throw new Exception("No se pudo determinar el nivel jerárquico de la nueva familia.");
            _repo.CrearPermiso(codigo.Trim(), nombre.Trim(), "F", nivelNuevo);
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

        public bool PuedeContener(FamiliaBE contenedor, FamiliaBE aAgregar)
        {
            return aAgregar.Codigo != CodigosPermiso.FamiliaAdmin;
        }

        public void AgregarFamiliaAFamilia(int idContenedor, int idAgregar)
        {
            var arbol = _repo.ObtenerArbolCompleto();
            var contenedor = BuscarPorId(arbol, idContenedor) as FamiliaBE;
            if (contenedor == null) throw new Exception("Familia contenedora no encontrada.");
            var aAgregar = BuscarPorId(arbol, idAgregar) as FamiliaBE;
            if (aAgregar == null) throw new Exception("Familia a agregar no encontrada.");

            if (!PuedeContener(contenedor, aAgregar))
                throw new Exception(
                    $"El Perfil Administrador global ({CodigosPermiso.FamiliaAdmin}) " +
                    $"no puede ser asignado dentro de ninguna otra familia.");

            contenedor.AgregarPermiso(aAgregar);
            _repo.AgregarHijo(idContenedor, idAgregar);
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
