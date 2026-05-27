using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnidadBLL
    {
        private readonly UnidadDAL _unidadDAL = new UnidadDAL();

        // CU07 - Obtener todas las unidades
        public List<UnidadBE> ObtenerTodas()
        {
            try
            {
                return _unidadDAL.ObtenerTodas();
            }
            catch
            {
                throw;
            }
        }
        // CU07 - Obtener unidades del consorcio seleccionado
        public List<UnidadBE> ObtenerPorConsorcio(string idConsorcio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idConsorcio))
                    throw new ArgumentException("Debe seleccionar un consorcio.");
                return _unidadDAL.ObtenerPorConsorcio(idConsorcio);
            }
            catch { throw; }
        }

        public UnidadBE ObtenerPorId(int idUnidad)
        {
            try
            {
                return _unidadDAL.ObtenerPorId(idUnidad);
            }
            catch { throw; }
        }

        // CU07 - Crear nueva unidad
        public void Crear(UnidadBE unidadBE)
        {
            try
            {
                ValidarUnidad(unidadBE);

                // FA1: piso+depto duplicado
                if (_unidadDAL.ExistePisoDepto(unidadBE.Id_Consorcio, unidadBE.Piso, unidadBE.Depto))
                    throw new Exception("La unidad ya existe en este consorcio.");


                ValidarInactivacion(unidadBE.Id_Unidad);

                _unidadDAL.Crear(unidadBE);
            }
            catch { throw; }
        }

        // CU07 FA2 - Editar unidad
        public void Actualizar(UnidadBE unidadBE)
        {
            try
            {
                ValidarUnidad(unidadBE);

                if (_unidadDAL.ExistePisoDepto(unidadBE.Id_Consorcio, unidadBE.Piso, unidadBE.Depto, unidadBE.Id_Unidad))
                    throw new Exception("La unidad ya existe en este consorcio.");

                _unidadDAL.Actualizar(unidadBE);
            }
            catch { throw; }
        }

        public void Eliminar(UnidadBE unidadBE)
        {
            try
            {
                if(unidadBE is not UnidadBE)
                {
                    throw new Exception("Error en cargar la unidad.");
                }

                _unidadDAL.Eliminar(unidadBE);
            }
            catch { throw; }

        }

        // CU07 FA3 - Validar si se puede inactivar
        public void ValidarInactivacion(int idUnidad)
        {
            try
            {
                if (_unidadDAL.TieneExpensasPendientes(idUnidad))
                    throw new Exception("No se puede inactivar: la unidad tiene expensas pendientes.");
            }
            catch { throw; }
        }

        private void ValidarUnidad(UnidadBE u)
        {
            if (string.IsNullOrWhiteSpace(u.Piso))
                throw new ArgumentException("El piso es obligatorio.");
            if (string.IsNullOrWhiteSpace(u.Depto))
                throw new ArgumentException("El departamento es obligatorio.");
            // FA2: superficie inválida
            if (u.Superficie.HasValue && u.Superficie <= 0)
                throw new ArgumentException("La superficie debe ser mayor a cero.");
        }
    }
}
