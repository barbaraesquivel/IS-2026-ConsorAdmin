using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class ConsorcistaMapper
    {
        // EF → Entity
        public static ConsorcistaBE Map(Consorcistum consorcista)
        {
            return new ConsorcistaBE()
            {
                Id_Consorcista = consorcista.IdConsorcista.ToString(),
                Id_Usuario = consorcista.IdUsuario.ToString(),
                Dni = consorcista.Dni,
                Telefono = consorcista.Telefono,

                Usuario = consorcista.IdUsuarioNavigation != null
                    ? UsuarioMapper.Map(consorcista.IdUsuarioNavigation)
                    : null,
                unidadConsorcista = consorcista.UnidadConsorcista
                    .Select(Unidad_ConsorcistaMapper.Map)
                    .ToList()
            };
        }

        // Entity → EF
        public static Consorcistum Map(ConsorcistaBE consorcistaBE)
        {
            return new Consorcistum()
            {
                IdConsorcista = Guid.Parse(consorcistaBE.Id_Consorcista),
                IdUsuario = consorcistaBE.Usuario != null
                    ? consorcistaBE.Usuario.Id
                    : Guid.Parse(consorcistaBE.Id_Usuario!),
                Dni = consorcistaBE.Dni,
                Telefono = consorcistaBE.Telefono,
                UnidadConsorcista = consorcistaBE.unidadConsorcista
                    .Select(Unidad_ConsorcistaMapper.Map)
                    .ToList()
            };
        }
    }
}
