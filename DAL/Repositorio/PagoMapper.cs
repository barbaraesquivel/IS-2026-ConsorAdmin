using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class PagoMapper
    {
        
        // EF → Entity
        public static PagoBE Map(Pago pago)
        {
            return new PagoBE()
            {
                Id_Pago = pago.IdPago,
                Id_Expensa = pago.IdExpensa,
                Fecha = pago.Fecha.ToDateTime(TimeOnly.MinValue),
                Monto = pago.Monto,
                MedioPago = pago.MedioPago,
                NroComprobante = pago.NroComprobante,

                expensaBE = pago.IdExpensaNavigation != null
                    ? ExpensaMapper.Map(pago.IdExpensaNavigation)
                    : null
            };
        }

        // Entity → EF
        public static Pago Map(PagoBE pagoBE)
        {
            return new Pago()
            {
                IdPago = pagoBE.Id_Pago,
                IdExpensa = pagoBE.expensaBE != null
                    ? pagoBE.expensaBE.Id_Expensa
                    : pagoBE.Id_Expensa,
                Fecha = DateOnly.FromDateTime(pagoBE.Fecha),
                Monto = pagoBE.Monto,
                MedioPago = pagoBE.MedioPago,
                NroComprobante = pagoBE.NroComprobante
            };
        }
        
    }
}
