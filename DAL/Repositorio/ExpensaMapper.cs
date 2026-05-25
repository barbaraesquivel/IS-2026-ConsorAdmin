using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class ExpensaMapper
    {
        // EF → Entity
        public static ExpensaBE Map(Expensa expensa)
        {
            return new ExpensaBE()
            {
                Id_Expensa = expensa.IdExpensa,
                Id_Unidad = expensa.IdUnidad,
                Periodo = expensa.Periodo,
                Monto = expensa.Monto,
                Vencimiento = expensa.Vencimiento.ToDateTime(TimeOnly.MinValue),
                Estado = expensa.Estado,

                unidadBE = expensa.IdUnidadNavigation != null
                    ? UnidadMapper.Map(expensa.IdUnidadNavigation)
                    : null,
                pagos = expensa.Pagos
                    .Select(PagoMapper.Map)
                    .ToList()
            };
        }

        // Entity → EF
        public static Expensa Map(ExpensaBE expensaBE)
        {
            return new Expensa()
            {
                IdExpensa = expensaBE.Id_Expensa,
                IdUnidad = expensaBE.Id_Unidad!,
                Periodo = expensaBE.Periodo,
                Monto = expensaBE.Monto,
                Vencimiento = DateOnly.FromDateTime(expensaBE.Vencimiento),
                Estado = expensaBE.Estado,
                Pagos = expensaBE.pagos
                    .Select(PagoMapper.Map)
                    .ToList()
            };
        }
    }
}
