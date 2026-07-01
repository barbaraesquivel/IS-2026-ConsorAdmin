using BLL;
using System;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public static class PermisoHelper
    {
        public static void AplicarPermiso(Control control, string codigoPatente, Guid idUsuario, IPermisoBLL bll)
        {
            control.Visible = bll.TienePatente(idUsuario, codigoPatente);
        }

    }
}
