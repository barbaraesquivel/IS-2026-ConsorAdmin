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
    public partial class formCargarExpA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formCargarExpA()
        {
            InitializeComponent();
        }

        private void formCargarExpA_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formCargarExpA_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxNuevaExpensa_FormCargarExpA.Tag = "groupBoxNuevaExpensa_FormCargarExpA";
            buttonCargar_FormCargarExpA.Tag = "buttonCargar_FormCargarExpA";
            buttonCanc_FormCargarExpA.Tag = "buttonCanc_FormCargarExpA";
            labelSituacion_FormCargarExpA.Tag = "labelSituacion_FormCargarExpA";
            labelVencimiento_FormCargarExpA.Tag = "labelVencimiento_FormCargarExpA";
            labelFecha_FormCargarExpA.Tag = "labelFecha_FormCargarExpA";
            labelImporte_FormCargarExpA.Tag = "labelImporte_FormCargarExpA";
            labelSubRubro_FormCargarExpA.Tag = "labelSubRubro_FormCargarExpA";
            labelRubro_FormCargarExpA.Tag = "labelRubro_FormCargarExpA";
            labelTipoExp_FormCargarExpA.Tag = "labelTipoExp_FormCargarExpA";
            labelEdificio_FormCargarExpA.Tag = "labelEdificio_FormCargarExpA";
        }
    }
}
