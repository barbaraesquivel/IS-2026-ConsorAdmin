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
            // No llamamos a UnidadMapper ni a ConsorcistaMapper para evitar ciclos:
            //   UC → Unidad → UC  (ciclo 1)
            //   UC → Consorcista → UC  (ciclo 2)
            // Construimos un ConsorcistaBE mínimo con solo los datos de display.
            ConsorcistaBE minimalConsorcista = null;
            if (unidadConsorcista.IdConsorcistaNavigation != null)
            {
                var c = unidadConsorcista.IdConsorcistaNavigation;
                minimalConsorcista = new ConsorcistaBE
                {
                    Id_Consorcista = c.IdConsorcista,
                    Dni = c.Dni,
                    Telefono = c.Telefono,
                    Id_Usuario = c.IdUsuario.ToString(),
                    Usuario = c.IdUsuarioNavigation != null
                        ? new UsuarioBE { Id = c.IdUsuarioNavigation.IdUsuario, Usuario = c.IdUsuarioNavigation.Username }
                        : null
                };
            }

            return new Unidad_ConsorcistaBE()
            {
                Id_Unidad_Consorcista = unidadConsorcista.IdUnidadConsorcista,
                Id_Unidad = unidadConsorcista.IdUnidad.ToString(),
                Id_Consorcista = unidadConsorcista.IdConsorcista.ToString(),
                TipoVinculo = unidadConsorcista.TipoVinculo,
                unidadBE = null,
                consorcistaBE = minimalConsorcista
            };
        }

        // Entity → EF
        public static UnidadConsorcistum Map(Unidad_ConsorcistaBE unidad_ConsorcistaBE)
        {
            return new UnidadConsorcistum()
            {
                IdUnidadConsorcista = unidad_ConsorcistaBE.Id_Unidad_Consorcista,
                TipoVinculo = unidad_ConsorcistaBE.TipoVinculo,
                IdConsorcista = Guid.Parse(unidad_ConsorcistaBE.Id_Consorcista),
                IdUnidad = int.Parse(unidad_ConsorcistaBE.Id_Unidad)
            };
        }
        
    }
}
