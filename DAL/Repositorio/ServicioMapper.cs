using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class ServicioMapper
    {
        // EF → Entity
        public static ServicioBE Map(Servicio servicio)
        {
            return new ServicioBE()
            {
                Id_Servicio = servicio.IdServicio.ToString(),
                Id_Proovedor = servicio.IdProveedor,
                Id_Consorcio = Guid.Parse(servicio.IdConsorcio),
                Descripcion = servicio.Descripcion,
                Fecha = servicio.Fecha.ToDateTime(TimeOnly.MinValue),
                Monto = servicio.Monto,
                Estado = servicio.Estado,
                Factura = servicio.Factura,

                proovedorBE = servicio.IdProveedorNavigation != null
                    ? ProovedorMapper.Map(servicio.IdProveedorNavigation)
                    : null,
                consorcioBE = servicio.IdConsorcioNavigation != null
                    ? ConsorcioMapper.Map(servicio.IdConsorcioNavigation)
                    : null
            };
        }

        // Entity → EF
        public static Servicio Map(ServicioBE servicioBE)
        {
            return new Servicio()
            {
                IdServicio = Guid.Parse(servicioBE.Id_Servicio),
                IdProveedor = servicioBE.proovedorBE != null
                    ? servicioBE.proovedorBE.Id_Proovedor
                    : servicioBE.Id_Proovedor,
                IdConsorcio = servicioBE.Id_Consorcio.ToString(),
                Descripcion = servicioBE.Descripcion,
                Fecha = DateOnly.FromDateTime(servicioBE.Fecha),
                Monto = servicioBE.Monto,
                Estado = servicioBE.Estado,
                Factura = servicioBE.Factura
            };
        }
    }
}
