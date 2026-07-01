using BE;
using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class IdiomaMapper
    {
        public static IdiomaBE Map(Idioma model)
        {
            if (model == null) return null;
            return new IdiomaBE
            {
                IdIdioma = model.IdIdioma,
                Nombre = model.Nombre,
                EsDefault = model.EsDefault
            };
        }

        public static Idioma Map(IdiomaBE be)
        {
            if (be == null) return null;
            return new Idioma
            {
                IdIdioma = be.IdIdioma,
                Nombre = be.Nombre,
                EsDefault = be.EsDefault
            };
        }
    }
}
