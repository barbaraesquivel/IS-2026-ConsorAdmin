using System.Collections.Generic;

namespace BLL
{
    public class ResultadoVerificacion
    {
        public bool Inicializado { get; set; }
        public List<string> FilasConDvhInvalido { get; set; } = new();
        public bool DvvInvalido { get; set; }

        public bool Ok => Inicializado
                       && FilasConDvhInvalido.Count == 0
                       && !DvvInvalido;
    }
}
