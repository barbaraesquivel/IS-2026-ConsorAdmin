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
    public partial class formVerP : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formVerP()
        {
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void formVerP_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formVerP_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxModificarServ_FormVerP.Tag = "groupBoxModificarServ_FormVerP";
            labelExpensa_FormVerP.Tag = "labelExpensa_FormVerP";
            buttonEditar_FormVerP.Tag = "buttonEditar_FormVerP";
            labelEstado_FormVerP.Tag = "labelEstado_FormVerP";
            labelGastos_FormVerP.Tag = "labelGastos_FormVerP";
            labelMonto_FormVerP.Tag = "labelMonto_FormVerP";
            labelNFactura_FormVerP.Tag = "labelNFactura_FormVerP";
            labelFechaPrest_FormVerP.Tag = "labelFechaPrest_FormVerP";
            labelDetalle_FormVerP.Tag = "labelDetalle_FormVerP";
            labelTipoServ_FormVerP.Tag = "labelTipoServ_FormVerP";
            labelConsorcio_FormVerP.Tag = "labelConsorcio_FormVerP";
            groupBoxExpensas_FormVerP.Tag = "groupBoxExpensas_FormVerP";
        }
    }
}
