using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_PROOVEDOR
{
    public partial class formInicioP : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formInicioP()
        {
            InitializeComponent();
        }

        private void formInicioP_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formInicioP_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        public void ActualizarIdioma(IdiomaBE idioma)
        {
            if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
            else Traducir(idioma);
        }

        private void Traducir(IdiomaBE idioma = null)
        {
            idioma ??= SessionManager.IdiomaActual ?? _traductorBLL.ObtenerIdiomaDefault();
            var t = _traductorBLL.ObtenerTraducciones(idioma);
            TraducirControles(this.Controls, t);
        }

        private void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> t)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl.Tag is string clave && t.ContainsKey(clave))
                    ctrl.Text = t[clave];
                if (ctrl.Controls.Count > 0)
                    TraducirControles(ctrl.Controls, t);
            }
        }

        private void AsignarTags()
        {
            groupBoxTotalFacturado_FormInicioP.Tag = "groupBoxTotalFacturado_FormInicioP";
            groupBoxCobrado_FormInicioP.Tag = "groupBoxCobrado_FormInicioP";
            groupBoxDeudas_FormInicioP.Tag = "groupBoxDeudas_FormInicioP";
            groupBoxEstado_FormInicioP.Tag = "groupBoxEstado_FormInicioP";
            groupBoxPendiente_FormInicioP.Tag = "groupBoxPendiente_FormInicioP";
        }
    }
}
