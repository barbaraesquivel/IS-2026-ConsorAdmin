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

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formDashA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formDashA()
        {
            InitializeComponent();
        }

        private void formDashA_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formDashA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado

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
            groupBoxTotalExp_FormDashA.Tag = "groupBoxTotalExp_FormDashA";
            groupBoxDeudas_FormDashA.Tag = "groupBoxDeudas_FormDashA";
            labelConsorcistas_FormDashA.Tag = "labelConsorcistas_FormDashA";
            groupBoxRecaudado_FormDashA.Tag = "groupBoxRecaudado_FormDashA";
            groupBoxUltimasExp_FormDashA.Tag = "groupBoxUltimasExp_FormDashA";
            groupBoxEdificios_FormDashA.Tag = "groupBoxEdificios_FormDashA";
            groupBoxPorCobrar_FormDashA.Tag = "groupBoxPorCobrar_FormDashA";
        }
    }
}
