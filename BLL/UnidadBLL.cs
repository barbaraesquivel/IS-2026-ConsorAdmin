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
        private readonly ConsorcioDAL _consorcioDAL = new ConsorcioDAL();

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

        // CU07 - Crear nueva unidad; retorna el ID asignado por la base de datos
        public int Crear(UnidadBE unidadBE)
        {
            try
            {
                ValidarUnidad(unidadBE);

                if (_unidadDAL.ExistePisoDepto(unidadBE.Id_Consorcio, unidadBE.Piso, unidadBE.Depto))
                    throw new UnidadDuplicadaException("La unidad ya existe en este consorcio (mismo piso y departamento).");

                var consorcio = _consorcioDAL.ObtenerPorId(unidadBE.Id_Consorcio);
                if (consorcio != null)
                {
                    int cantExistentes = _unidadDAL.ContarPorConsorcio(unidadBE.Id_Consorcio);
                    if (cantExistentes >= consorcio.CantUnidades)
                        throw new Exception(
                            $"El consorcio ya alcanzó el máximo de {consorcio.CantUnidades} unidad(es) permitida(s). " +
                            "Modifique la capacidad del consorcio antes de agregar más.");
                }

                return _unidadDAL.Crear(unidadBE);
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
                    throw new UnidadDuplicadaException("La unidad ya existe en este consorcio (mismo piso y departamento).");

                _unidadDAL.Actualizar(unidadBE);
            }
            catch { throw; }
        }

        public void Eliminar(UnidadBE unidadBE)
        {
            try
            {
                if (unidadBE == null)
                    throw new ValidacionException("Error al cargar la unidad.");

                if (_unidadDAL.TieneExpensasPendientes(unidadBE.Id_Unidad))
                    throw new ValidacionException("No se puede eliminar: la unidad tiene expensas pendientes o vencidas.");

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
                throw new ValidacionException("El piso es obligatorio.");
            if (string.IsNullOrWhiteSpace(u.Depto))
                throw new ValidacionException("El departamento es obligatorio.");
            if (!u.Superficie.HasValue || u.Superficie <= 0)
                throw new ValidacionException("La superficie es obligatoria y debe ser mayor a cero.");
        }
    }
}
