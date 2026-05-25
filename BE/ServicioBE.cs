using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ServicioBE
    {
        public string Id_Servicio { get; set; }
        public Guid Id_Proovedor { get; set; }
        public Guid Id_Consorcio { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string Factura { get; set; }
        public ProovedorBE proovedorBE { get; set; }
        public ConsorcioBE consorcioBE { get; set; }
    }
}
