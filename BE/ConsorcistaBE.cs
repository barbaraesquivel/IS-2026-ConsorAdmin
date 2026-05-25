using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ConsorcistaBE
    {
        public string Id_Consorcista { get; set; }
        public string? Id_Usuario { get; set; }
        public string Dni {  get; set; }
        public string Telefono { get; set; }
        public UsuarioBE Usuario { get; set; }
        public List<Unidad_ConsorcistaBE> unidadConsorcista { get; set; }
    }
}
