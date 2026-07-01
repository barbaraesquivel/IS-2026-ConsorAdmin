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

namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    public partial class FormRecauG : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public FormRecauG()
        {
            InitializeComponent();
        }

        private void FormRecauG_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void FormRecauG_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxSinAsignar_FormRecauG.Tag = "groupBoxSinAsignar_FormRecauG";
            groupBoxFondo_FormRecauG.Tag = "groupBoxFondo_FormRecauG";
            groupBoxAsignarFondos_FormRecauG.Tag = "groupBoxAsignarFondos_FormRecauG";
            labelMonto_FormRecauG.Tag = "labelMonto_FormRecauG";
            labelDescripcion_FormRecauG.Tag = "labelDescripcion_FormRecauG";
            labelCategoria_FormRecauG.Tag = "labelCategoria_FormRecauG";
            labelEdificio_FormRecauG.Tag = "labelEdificio_FormRecauG";
            groupBoxAsignado_FormRecauG.Tag = "groupBoxAsignado_FormRecauG";
        }
    }
}
