using BE;
using DAL.Models;
using DAL.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicioDAL
    {
        // CU09 - Obtener servicios por consorcio y período
        public List<ServicioBE> ObtenerPorConsorcioYPeriodo(string idConsorcio, string periodo)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Servicios
                    .Where(s => s.IdConsorcio == idConsorcio &&
                                s.Fecha.ToString("yyyy-MM") == periodo)
                    .Include(s => s.IdProveedorNavigation)
                    .Include(s => s.IdConsorcioNavigation)
                    .Select(s => ServicioMapper.Map(s))
                    .ToList();
            }
            catch { throw; }
        }

        // CU09 - Obtener por ID
        public ServicioBE ObtenerPorId(Guid idServicio)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Servicios
                    .Include(s => s.IdProveedorNavigation)
                    .Include(s => s.IdConsorcioNavigation)
                    .FirstOrDefault(s => s.IdServicio == idServicio);
                return ServicioMapper.Map(model);
            }
            catch { throw; }
        }

        // CU09 - Crear gasto/servicio
        public void Crear(ServicioBE servicioBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ServicioMapper.Map(servicioBE);
                model.IdServicio = Guid.NewGuid();
                ctx.Servicios.Add(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }

        // CU09 FA3 - Verificar si el período ya fue liquidado
        public bool PeriodoLiquidado(string idConsorcio, string periodo)
        {
            try
            {
                using var ctx = new AppDbContext();
                // Un período está liquidado si existen expensas generadas para ese consorcio/período
                return ctx.Expensas.Any(e =>
                    e.IdUnidadNavigation.IdConsorcio == idConsorcio &&
                    e.Periodo == periodo &&
                    e.Estado != "Anulada");
            }
            catch { throw; }
        }
    }
}
