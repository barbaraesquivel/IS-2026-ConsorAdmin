using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class ConsorcioMapper
    {
        public static ConsorcioBE Map(Consorcio consorcio)
        {
            return new ConsorcioBE()
            {
                Id_Consorcio = consorcio.IdConsorcio,
                Nombre = consorcio.Nombre,
                Direccion = consorcio.Direccion,
                CantUnidades = consorcio.CantUnidades,

                Servicios = consorcio.Servicios
                            .Select(ServicioMapper.Map)
                            .ToList(),
                Unidades = consorcio.Unidads
                            .Select(UnidadMapper.Map)
                            .ToList()

            };
        }

        // Entity → EF
        public static Consorcio Map(ConsorcioBE consorcioBE)
        {
            return new Consorcio()
            {
                IdConsorcio = consorcioBE.Id_Consorcio,
                CantUnidades = consorcioBE.CantUnidades,
                Nombre = consorcioBE.Nombre,
                Direccion = consorcioBE.Direccion,

                Servicios = consorcioBE.Servicios
                            .Select(ServicioMapper.Map)
                            .ToList(),
                Unidads = consorcioBE.Unidades
                            .Select(UnidadMapper.Map)
                            .ToList()
            };
        }
    }
}
