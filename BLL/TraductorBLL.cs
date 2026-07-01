using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TraductorBLL
    {
        private readonly DAL.TraductorDAL _dal = new DAL.TraductorDAL();

        public List<IdiomaBE> ObtenerIdiomas() => _dal.ObtenerIdiomas();

        public IdiomaBE ObtenerIdiomaDefault() => _dal.ObtenerIdiomaDefault();

        public IdiomaBE ObtenerIdiomaPorId(int idIdioma) => _dal.ObtenerIdiomaPorId(idIdioma);

        public IdiomaBE AgregarIdioma(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new System.Exception("El nombre del idioma no puede estar vacío.");
            if (_dal.ObtenerIdiomas().Any(i => i.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase)))
                throw new System.Exception("Ya existe un idioma con ese nombre.");
            return _dal.AgregarIdioma(nombre);
        }

        public List<string> ObtenerClavesPorFormulario(string formulario)
            => _dal.ObtenerClavesPorFormulario(formulario);

        public void GuardarTraduccion(int idIdioma, string clave, string texto, string formulario)
        {
            int idEtiqueta = _dal.ObtenerOCrearEtiqueta(clave, formulario);
            _dal.GuardarTraduccion(idIdioma, idEtiqueta, texto);
        }

        public Dictionary<string, string> ObtenerTraducciones(IdiomaBE idioma)
            => _dal.ObtenerTraducciones(idioma.IdIdioma);

        public List<TraduccionBE> ObtenerTraduccionesConClave(int idIdioma)
            => _dal.ObtenerTraduccionesConClave(idIdioma);

        public List<(string Clave, string Original, string Traduccion)> ObtenerParaEdicion(int idIdioma)
            => _dal.ObtenerParaEdicion(idIdioma);
    }
}
