using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UnidadBE
    {
        public int Id_Unidad { get; set; }
        public string Id_Consorcio { get; set; }
        public string Piso {  get; set; }
        public string Depto { get; set; }
        public decimal? Superficie { get; set; }
        public List<ExpensaBE> expensas {  get; set; }
        public List<Unidad_ConsorcistaBE> unidadConsorcista { get; set; }
        public ConsorcioBE consorcioBE { get; set; }

        public string Descripcion
        {
            get
            {
                return $"{Id_Consorcio} - Piso {Piso} Depto {Depto}";
            }
        }
    }
}
