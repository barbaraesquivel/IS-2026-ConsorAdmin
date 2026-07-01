using System.Collections.Generic;

namespace BLL
{
    public class ResultadoRestauracion
    {
        public int Actualizadas { get; set; }
        public int Insertadas { get; set; }
        public int Eliminadas { get; set; }
        public List<string> Errores { get; set; } = new List<string>();
    }
}
