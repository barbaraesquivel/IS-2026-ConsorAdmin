using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnidadConsorcistaBLL
    {
        private readonly DAL.UnidadConsorcistaDAL _dal = new DAL.UnidadConsorcistaDAL();

        public List<Unidad_ConsorcistaBE> ObtenerPorUnidad(int idUnidad)
        {
            try
            {
                return _dal.ObtenerPorUnidad(idUnidad);
            }
            catch { throw; }
        }

        public List<ConsorcistaBE> ObtenerConsorcistasDisponibles()
        {
            try
            {
                return _dal.ObtenerConsorcistasDisponibles();
            }
            catch { throw; }
        }

        public void Asociar(int idUnidad, string idConsorcista, string tipoVinculo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tipoVinculo))
                    throw new ArgumentException("El tipo de vinculo es obligatorio.");

                if (ExisteAsociacion(idUnidad, idConsorcista))
                    throw new Exception("El consorcista ya esta asociado a esta unidad.");

                var asociacion = new Unidad_ConsorcistaBE
                {
                    Id_Unidad = idUnidad.ToString(),
                    Id_Consorcista = idConsorcista.ToString(),
                    TipoVinculo = tipoVinculo
                };

                _dal.Asociar(asociacion);
            }
            catch { throw; }
        }

        public void Eliminar(Unidad_ConsorcistaBE unidad_ConsorcistaBE)
        {
            try
            {
                if (unidad_ConsorcistaBE is not Unidad_ConsorcistaBE)
                {
                    throw new ArgumentException("Relacion no encontrada.");
                }
                _dal.Eliminar(unidad_ConsorcistaBE);
            }
            catch { throw; }

        }

        public bool ExisteAsociacion(int idUnidad, string idConsorcista)
        {
            try
            {
                if(idUnidad == null || idConsorcista == null)
                {
                    throw new Exception("Campos Invalidos.");
                }

                return _dal.ExisteAsociacion(idUnidad, Guid.Parse(idConsorcista));

            }
            catch { throw; }

        }

        public void QuitarAsociacion(int idUnidadConsorcista)
        {
            try
            {
                _dal.QuitarAsociacion(idUnidadConsorcista);
            }
            catch { throw; }
        }
    }
}
