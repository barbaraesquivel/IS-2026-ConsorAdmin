using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LogBitacoraBE
    {
        public int Id_Log { get; set; }
        public Guid Id_Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public string Accion { get; set; }
        public string Modulo { get; set; }
        public string? Detalle { get; set; }
        public UsuarioBE usuarioBE { get; set; }
    }
}
