using System.Collections.Generic;

namespace BE
{
    public interface IVerificable
    {
        string GetIdentificador();
        List<string> GetValoresParaDV();
        int DVH { get; set; }
    }
}
