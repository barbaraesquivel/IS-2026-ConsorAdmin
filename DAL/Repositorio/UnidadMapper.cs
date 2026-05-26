using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class UnidadMapper
    {
        
        public static UnidadBE Map(Unidad unidad)
        {
            return new UnidadBE()
            {
                Id_Unidad = unidad.IdUnidad,
                Piso = unidad.Piso,
                Depto = unidad.Depto,
                Superficie = unidad.Superficie,
                Id_Consorcio = unidad.IdConsorcio,

                expensas = unidad.Expensas
                            .Select(ExpensaMapper.Map)
                            .ToList(),
                unidadConsorcista = unidad.UnidadConsorcista
                            .Select(Unidad_ConsorcistaMapper.Map)
                            .ToList(),

                consorcioBE = unidad.IdConsorcioNavigation != null
                    ? ConsorcioMapper.Map(unidad.IdConsorcioNavigation)
                    : null

            };
        }

        // Entity → EF
        public static Unidad Map(UnidadBE unidadBE)
        {
            return new Unidad()
            {
                IdUnidad = unidadBE.Id_Unidad,
                Piso = unidadBE.Piso,
                Depto = unidadBE.Depto,
                Superficie = unidadBE.Superficie,

                IdConsorcio = unidadBE.consorcioBE?.Id_Consorcio,
                Expensas = unidadBE.expensas
                            .Select(ExpensaMapper.Map)
                            .ToList(),
                UnidadConsorcista = unidadBE.unidadConsorcista
                                    .Select(Unidad_ConsorcistaMapper.Map)
                                    .ToList(),

            };
        }
    }
}
