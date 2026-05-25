using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ExpensaBE
    {
        public Guid Id_Expensa { get; set; }
        public string? Id_Unidad { get; set; }
        public string Periodo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Estado { get; set; }
        public UnidadBE unidadBE { get; set; }
        public List<PagoBE> pagos { get; set; }

    }
}
