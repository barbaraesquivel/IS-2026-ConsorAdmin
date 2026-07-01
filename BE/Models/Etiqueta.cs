using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Models
{
    public partial class Etiqueta
    {
        public int IdEtiqueta { get; set; }
        public string Clave { get; set; }
        public string Formulario { get; set; }

        public ICollection<Traduccion> Traducciones { get; set; } = new List<Traduccion>();
    }
}
