using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TraduccionBE
    {
        public int IdTraduccion { get; set; }
        public int IdIdioma { get; set; }
        public int IdEtiqueta { get; set; }
        public string Clave { get; set; }   // viene de la etiqueta relacionada, no es columna propia
        public string Texto { get; set; }
    }
}
