using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Models
{
    public partial class Traduccion
    {
        public int IdTraduccion { get; set; }
        public int IdIdioma { get; set; }
        public int IdEtiqueta { get; set; }
        public string Texto { get; set; }
        public Idioma IdIdiomaNavigation { get; set; }
        public Etiqueta IdEtiquetaNavigation { get; set; }
    }
}
