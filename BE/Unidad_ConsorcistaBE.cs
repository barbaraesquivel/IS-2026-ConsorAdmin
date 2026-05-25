using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Unidad_ConsorcistaBE
    {
        public string Id_Unidad_Consorcista {  get; set; }
        public string Id_Unidad { get; set; }
        public string Id_Consorcista { get; set; }
        public string TipoVinculo { get; set; }
        public UnidadBE unidadBE { get; set; }
        public ConsorcistaBE consorcistaBE { get; set; }
    }
}
