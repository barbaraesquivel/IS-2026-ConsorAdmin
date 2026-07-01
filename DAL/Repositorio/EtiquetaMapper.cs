using BE;
using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class EtiquetaMapper
    {
        public static EtiquetaBE Map(Etiqueta model)
        {
            if (model == null) return null;
            return new EtiquetaBE
            {
                IdEtiqueta = model.IdEtiqueta,
                Clave = model.Clave,
                Formulario = model.Formulario
            };
        }

        public static Etiqueta Map(EtiquetaBE be)
        {
            if (be == null) return null;
            return new Etiqueta
            {
                IdEtiqueta = be.IdEtiqueta,
                Clave = be.Clave,
                Formulario = be.Formulario
            };
        }
    }
}
