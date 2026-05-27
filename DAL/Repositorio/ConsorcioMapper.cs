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

        // EF → Entity
        public static ConsorcioBE Map(Consorcio consorcio)
        {
            if (consorcio == null) return null;

            return new ConsorcioBE()
            {
                Id_Consorcio = consorcio.IdConsorcio,
                Nombre = consorcio.Nombre,
                Direccion = consorcio.Direccion,
                CantUnidades = consorcio.CantUnidades,

                Servicios = consorcio.Servicios?
                            .Select(ServicioMapper.Map)
                            .ToList() ?? new List<ServicioBE>(),

                Unidades = consorcio.Unidads?
                            .Select(UnidadMapper.Map)
                            .ToList() ?? new List<UnidadBE>(),

                gestorConsorcios = consorcio.GestorConsorcios?
                    .Select(GestorConsorcioMapper.Map)
                    .ToList() ?? new List<GestorConsorcioBE>()
            };
        }

        // Entity → EF
        public static Consorcio Map(ConsorcioBE consorcioBE)
        {
            if (consorcioBE == null) return null;

            return new Consorcio()
            {
                // Si no viene Id (operación de creación), generar uno nuevo
                IdConsorcio = string.IsNullOrWhiteSpace(consorcioBE.Id_Consorcio)
                    ? Guid.NewGuid().ToString()
                    : consorcioBE.Id_Consorcio,

                CantUnidades = consorcioBE.CantUnidades,
                Nombre = consorcioBE.Nombre,
                Direccion = consorcioBE.Direccion,

                Servicios = consorcioBE.Servicios?
                            .Select(ServicioMapper.Map)
                            .ToList() ?? new List<Servicio>(),

                Unidads = consorcioBE.Unidades?
                            .Select(UnidadMapper.Map)
                            .ToList() ?? new List<Unidad>(),

                GestorConsorcios = consorcioBE.gestorConsorcios?
                    .Select(GestorConsorcioMapper.Map)
                    .ToList() ?? new List<GestorConsorcio>()
            };
        }

    }
}
