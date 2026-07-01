using BE;
using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class TraduccionMapper
    {
        // Mapea incluyendo la Clave de la etiqueta relacionada (requiere .Include en la query)
        public static TraduccionBE Map(Traduccion model)
        {
            if (model == null) return null;
            return new TraduccionBE
            {
                IdTraduccion = model.IdTraduccion,
                IdIdioma = model.IdIdioma,
                IdEtiqueta = model.IdEtiqueta,
                Clave = model.IdEtiquetaNavigation?.Clave,
                Texto = model.Texto
            };
        }

        public static Traduccion Map(TraduccionBE be)
        {
            if (be == null) return null;
            return new Traduccion
            {
                IdTraduccion = be.IdTraduccion,
                IdIdioma = be.IdIdioma,
                IdEtiqueta = be.IdEtiqueta,
                Texto = be.Texto
            };
        }
    }
}
