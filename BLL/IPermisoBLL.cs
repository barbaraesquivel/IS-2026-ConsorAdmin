using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public interface IPermisoBLL
    {
        // Devuelve el árbol expandido de permisos del usuario (Familias con sus Patentes incluidas)
        List<ComponentePermisoBE> ObtenerArbolDeUsuario(Guid idUsuario);

        // True si el usuario tiene esa patente (directamente o vía una Familia asignada)
        bool TienePatente(Guid idUsuario, string codigoPatente);

        // True si el usuario tiene al menos una patente de la familia indicada
        bool TieneAlgunaPatenteDeFamilia(Guid idUsuario, string codigoFamilia);
    }
}
