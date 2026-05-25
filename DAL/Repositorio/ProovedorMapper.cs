using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class ProovedorMapper
    {
        // EF → Entity
        public static ProovedorBE Map(Proveedor proveedor)
        {
            return new ProovedorBE()
            {
                Id_Proovedor = proveedor.IdProveedor,
                Id_Usuario = proveedor.IdUsuario,
                Cuit = proveedor.Cuit,
                Rubro = proveedor.Rubro,

                usuarioBE = proveedor.IdUsuarioNavigation != null
                    ? UsuarioMapper.Map(proveedor.IdUsuarioNavigation)
                    : null,
                servicios = proveedor.Servicios
                    .Select(ServicioMapper.Map)
                    .ToList()
            };
        }

        // Entity → EF
        public static Proveedor Map(ProovedorBE proovedorBE)
        {
            return new Proveedor()
            {
                IdProveedor = proovedorBE.Id_Proovedor,
                IdUsuario = proovedorBE.usuarioBE != null
                    ? proovedorBE.usuarioBE.Id
                    : proovedorBE.Id_Usuario,
                Cuit = proovedorBE.Cuit,
                Rubro = proovedorBE.Rubro,
                Servicios = proovedorBE.servicios
                    .Select(ServicioMapper.Map)
                    .ToList()
            };
        }
    }
}
