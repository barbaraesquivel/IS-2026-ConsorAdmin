using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Models
{
    public partial class Idioma
    {
        public int IdIdioma { get; set; }
        public string Nombre { get; set; }
        public bool EsDefault { get; set; }
        public ICollection<Traduccion> Traducciones { get; set; } = new List<Traduccion>();
    }
}
