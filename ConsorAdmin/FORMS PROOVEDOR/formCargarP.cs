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
    public partial class formCargarP : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formCargarP()
        {
            InitializeComponent();
        }

        private void formCargarP_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formCargarP_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxRegistrarServ_FormCargarP.Tag = "groupBoxRegistrarServ_FormCargarP";
            labelEstado_FormCargarP.Tag = "labelEstado_FormCargarP";
            labelGastos_FormCargarP.Tag = "labelGastos_FormCargarP";
            labelMonto_FormCargarP.Tag = "labelMonto_FormCargarP";
            labelNFact_FormCargarP.Tag = "labelNFact_FormCargarP";
            labelFecha_FormCargarP.Tag = "labelFecha_FormCargarP";
            labelDetalle_FormCargarP.Tag = "labelDetalle_FormCargarP";
            labelTipoServ_FormCargarP.Tag = "labelTipoServ_FormCargarP";
            labelConsorcio_FormCargarP.Tag = "labelConsorcio_FormCargarP";
            buttonLimpiar_FormCargarP.Tag = "buttonLimpiar_FormCargarP";
            buttonCargarS_FormCargarP.Tag = "buttonCargarS_FormCargarP";
            labelTotal_FormCargarP.Tag = "labelTotal_FormCargarP";
        }
    }
}
