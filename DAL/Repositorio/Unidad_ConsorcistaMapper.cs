using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class Unidad_ConsorcistaMapper
    {
        public static Unidad_ConsorcistaBE Map(UnidadConsorcistum unidadConsorcista)
        {
            return new Unidad_ConsorcistaBE()
            {
                Id_Unidad_Consorcista = unidadConsorcista.IdUnidadConsorcista.ToString(),
                Id_Unidad = unidadConsorcista.IdUnidad.ToString(),
                Id_Consorcista = unidadConsorcista.IdConsorcista.ToString(),
                TipoVinculo = unidadConsorcista.TipoVinculo,

                unidadBE = unidadConsorcista.IdUnidadNavigation != null
                    ? UnidadMapper.Map(unidadConsorcista.IdUnidadNavigation)
                    : null,
                consorcistaBE = unidadConsorcista.IdConsorcistaNavigation != null
                    ? ConsorcistaMapper.Map(unidadConsorcista.IdConsorcistaNavigation)
                    : null


            };
        }

        // Entity → EF
        public static UnidadConsorcistum Map(Unidad_ConsorcistaBE unidad_ConsorcistaBE)
        {
            return new UnidadConsorcistum()
            {
                IdUnidadConsorcista = unidad_ConsorcistaBE.Id_Unidad,
                TipoVinculo = unidad_ConsorcistaBE.TipoVinculo,

                IdConsorcista = unidad_ConsorcistaBE.consorcistaBE?.Id_Consorcista,
                IdUnidad = unidad_ConsorcistaBE.unidadBE?.Id_Unidad

            };
        }
    }
}
