using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProovedorBE
    {
        public Guid Id_Proovedor {  get; set; }
        public Guid Id_Usuario { get; set; }
        public string Cuit {  get; set; }
        public string Rubro { get; set; }
        public UsuarioBE usuarioBE { get; set; }
    }
}
