using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EtiquetaBE
    {
        public int IdEtiqueta { get; set; }
        public string Clave { get; set; }
        public string Formulario { get; set; }   // 'Form1Admin' | 'Form1Gestor' | 'Form1Proveedor' | 'Form1Consorcista'
    }
}
