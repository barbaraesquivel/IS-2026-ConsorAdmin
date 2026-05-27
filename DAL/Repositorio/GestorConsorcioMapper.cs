using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class GestorConsorcioMapper
    {
        // EF → BE
        // No llamamos a UsuarioMapper ni ConsorcioMapper para evitar recursión infinita:
        //   Consorcio → GestorConsorcio → Consorcio  (ciclo 1)
        //   GestorConsorcio → Usuario → GestorConsorcio  (ciclo 2)
        // Se construye un UsuarioBE mínimo con solo los datos necesarios para mostrar.
        public static GestorConsorcioBE Map(GestorConsorcio gc)
        {
            if (gc == null) return null;
            return new GestorConsorcioBE()
            {
                Id_GestorConsorcio = gc.IdGestorConsorcio,
                Id_Usuario = gc.IdUsuario,
                Id_Consorcio = gc.IdConsorcio,
                FechaAsignacion = gc.FechaAsignacion.ToDateTime(TimeOnly.MinValue),

                usuarioBE = gc.IdUsuarioNavigation != null
                    ? new UsuarioBE
                    {
                        Id = gc.IdUsuarioNavigation.IdUsuario,
                        Usuario = gc.IdUsuarioNavigation.Username
                    }
                    : null,
                consorcioBE = null
            };
        }

        // BE → EF
        public static GestorConsorcio Map(GestorConsorcioBE gcBE)
        {
            if (gcBE == null) return null;
            return new GestorConsorcio()
            {
                IdGestorConsorcio = gcBE.Id_GestorConsorcio,
                IdUsuario = gcBE.Id_Usuario,
                IdConsorcio = gcBE.Id_Consorcio,
                FechaAsignacion = DateOnly.FromDateTime(gcBE.FechaAsignacion)
            };
        }
    }
}
