using System.Collections.Generic;
using System.Linq;

namespace BE
{
    public class ConsorcioBE : IVerificable
    {
        public string Id_Consorcio { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int CantUnidades { get; set; }
        public int DVH { get; set; }

        public List<ServicioBE> Servicios { get; set; }
        public List<GestorConsorcioBE> gestorConsorcios { get; set; }
        public List<UnidadBE> Unidades { get; set; }

        public string GetIdentificador() => Id_Consorcio;

        public List<string> GetValoresParaDV()
        {
            // Orden fijo: cualquier cambio en posición produce un DVH distinto.
            // La serialización de unidades ordena por Id_Unidad para que sea determinística.
            string unidadesSerial = Unidades == null || Unidades.Count == 0
                ? string.Empty
                : string.Join("-", Unidades.Select(u => u.Id_Unidad).OrderBy(id => id));

            return new List<string>
            {
                Id_Consorcio ?? string.Empty,
                Nombre       ?? string.Empty,
                Direccion    ?? string.Empty,
                CantUnidades.ToString(),
                unidadesSerial
            };
        }
    }
}
