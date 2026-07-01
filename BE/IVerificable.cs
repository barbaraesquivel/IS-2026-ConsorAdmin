using System.Collections.Generic;

namespace BE
{
    public interface IVerificable
    {
        string ObtenerIdentificador();
        List<string> ObtenerValoresParaDV();
        int DVH { get; set; }
    }
}
