using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PagoBE
    {
        public Guid Id_Pago { get; set; }
        public Guid Id_Expensa { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string MedioPago { get; set; }
        public string NroComprobante { get; set; }
        public ExpensaBE expensaBE { get; set; }
    }
}
