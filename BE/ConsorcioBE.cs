using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ConsorcioBE
    {
        public string Id_Consorcio { get; set; }
        public string Nombre { get; set; }
        public string Direccion {  get; set; }
        public int CantUnidades { get; set; }

        public List<ServicioBE> Servicios { get; set; }
        public List<GestorConsorcioBE> gestorConsorcios { get; set; }
        public List<UnidadBE> Unidades { get; set; }

    }
}
