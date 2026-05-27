using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioBLL
    {
        private readonly ServicioDAL _servicioDAL = new ServicioDAL();

        // CU09 - Obtener gastos del consorcio/período
        public List<ServicioBE> ObtenerPorConsorcioYPeriodo(string idConsorcio, string periodo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idConsorcio))
                    throw new ArgumentException("Debe seleccionar un consorcio.");
                if (string.IsNullOrWhiteSpace(periodo))
                    throw new ArgumentException("Debe seleccionar un período.");
                return _servicioDAL.ObtenerPorConsorcioYPeriodo(idConsorcio, periodo);
            }
            catch { throw; }
        }

        // CU09 - Registrar nuevo gasto
        public void Crear(ServicioBE servicioBE)
        {
            try
            {
                ValidarServicio(servicioBE);

                // FA1: período ya liquidado
                string periodo = servicioBE.Fecha.ToString("yyyy-MM");
                if (_servicioDAL.PeriodoLiquidado(servicioBE.Id_Consorcio.ToString(), periodo))
                    throw new Exception("El período seleccionado ya fue liquidado. No se pueden agregar gastos.");

                _servicioDAL.Crear(servicioBE);
            }
            catch { throw; }
        }

        private void ValidarServicio(ServicioBE s)
        {
            if (string.IsNullOrWhiteSpace(s.Descripcion))
                throw new ArgumentException("La descripción es obligatoria.");
            // FA2: monto inválido
            if (s.Monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero.");
            if (s.Fecha == default)
                throw new ArgumentException("La fecha es obligatoria.");
        }
    }
}
