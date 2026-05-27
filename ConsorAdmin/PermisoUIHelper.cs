using BLL;
using System;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public static class PermisoUIHelper
    {
        public static void AplicarPermiso(Control control, string codigoPatente, Guid idUsuario, IPermisoBLL bll)
        {
            control.Visible = bll.TienePatente(idUsuario, codigoPatente);
        }

        public static void AplicarPermisos(Guid idUsuario, IPermisoBLL bll,
            params (Control control, string codigoPatente)[] mapeo)
        {
            foreach (var (control, codigo) in mapeo)
                AplicarPermiso(control, codigo, idUsuario, bll);
        }
    }
}
