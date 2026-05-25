using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioPermisoBE
    {
        public string Id_Usuario_Permiso {  get; set; }
        public string Id_Usuario { get; set; }
        public string Id_Permiso { get; set; }
        public UsuarioBE usuarioBE { get; set; }
        public PermisoBE permisoBE { get; set; }
        
    }
}
