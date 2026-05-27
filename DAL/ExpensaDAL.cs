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
    public class ExpensaDAL
    {
        // CU10 - Obtener total de gastos aprobados del período (para calcular monto por unidad)
        public decimal ObtenerTotalGastosPeriodo(string idConsorcio, string periodo)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Servicios
                    .Where(s => s.IdConsorcio == idConsorcio &&
                                s.Fecha.ToString("yyyy-MM") == periodo &&
                                s.Estado == "Aprobado")
                    .Sum(s => s.Monto);
            }
            catch { throw; }
        }

        // CU10 - Obtener unidades activas del consorcio
        public List<UnidadBE> ObtenerUnidadesActivas(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Unidads
                    .Where(u => u.IdConsorcio == idConsorcio)
                    .Include(u => u.Expensas)
                    .Select(u => UnidadMapper.Map(u))
                    .ToList();
            }
            catch { throw; }
        }

        // CU10 - Liquidar: insertar expensa por cada unidad
        public void LiquidarExpensas(List<ExpensaBE> expensas)
        {
            try
            {
                using var ctx = new AppDbContext();
                foreach (var expensaBE in expensas)
                {
                    var model = ExpensaMapper.Map(expensaBE);
                    model.IdExpensa = Guid.NewGuid();
                    ctx.Expensas.Add(model);
                }
                ctx.SaveChanges();
            }
            catch { throw; }
        }

        // CU10/CU11 - Verificar si el período ya fue liquidado
        public bool PeriodoYaLiquidado(string idConsorcio, string periodo)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Expensas.Any(e =>
                    e.IdUnidadNavigation.IdConsorcio == idConsorcio &&
                    e.Periodo == periodo &&
                    e.Estado != "Anulada");
            }
            catch { throw; }
        }

        // CU11 - Consultar expensas con filtros
        public List<ExpensaBE> Consultar(string idConsorcio, string periodo, string estado, int? idUnidad)
        {
            try
            {
                using var ctx = new AppDbContext();
                var query = ctx.Expensas
                    .Include(e => e.IdUnidadNavigation)
                        .ThenInclude(u => u.IdConsorcioNavigation)
                    .Include(e => e.Pagos)
                    .Where(e => e.IdUnidadNavigation.IdConsorcio == idConsorcio);

                if (!string.IsNullOrWhiteSpace(periodo))
                    query = query.Where(e => e.Periodo == periodo);
                if (!string.IsNullOrWhiteSpace(estado))
                    query = query.Where(e => e.Estado == estado);
                if (idUnidad.HasValue)
                    query = query.Where(e => e.IdUnidad == idUnidad.Value);

                return query.Select(e => ExpensaMapper.Map(e)).ToList();
            }
            catch { throw; }
        }

        // CU11 - Obtener por ID
        public ExpensaBE ObtenerPorId(Guid idExpensa)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Expensas
                    .Include(e => e.IdUnidadNavigation)
                    .Include(e => e.Pagos)
                    .FirstOrDefault(e => e.IdExpensa == idExpensa);
                return ExpensaMapper.Map(model);
            }
            catch { throw; }
        }

        // CU12 - Verificar si tiene pagos asociados
        public bool TienePagos(Guid idExpensa)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Pagos.Any(p => p.IdExpensa == idExpensa);
            }
            catch { throw; }
        }

        // CU12 - Anular expensa
        public void Anular(Guid idExpensa)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Expensas.FirstOrDefault(e => e.IdExpensa == idExpensa);
                if (model == null) throw new Exception("Expensa no encontrada.");
                model.Estado = "Anulada";
                ctx.SaveChanges();
            }
            catch { throw; }
        }

        // Actualizar estado vencidas (para llamar al cargar pantalla)
        public void ActualizarVencidas()
        {
            try
            {
                using var ctx = new AppDbContext();
                var hoy = DateOnly.FromDateTime(DateTime.Today);
                var vencidas = ctx.Expensas
                    .Where(e => e.Estado == "Pendiente" && e.Vencimiento < hoy)
                    .ToList();
                foreach (var e in vencidas)
                    e.Estado = "Vencida";
                ctx.SaveChanges();
            }
            catch { throw; }
        }
    }
}
