using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GestorConsorcioBE
    {
        public int Id_GestorConsorcio { get; set; }
        public Guid Id_Usuario { get; set; }
        public string Id_Consorcio { get; set; }
        public DateTime FechaAsignacion { get; set; }

        public UsuarioBE usuarioBE { get; set; }
        public ConsorcioBE consorcioBE { get; set; }
    }
}
