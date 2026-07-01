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

namespace ConsorAdmin
{
    public partial class formInicioC : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formInicioC()
        {
            InitializeComponent();
        }

        private void formInicioC_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formInicioC_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxPagado_FormInicioC.Tag = "groupBoxPagado_FormInicioC";
            groupBoxDeuda_FormInicioC.Tag = "groupBoxDeuda_FormInicioC";
            groupBoxProxexp_FormInicioC.Tag = "groupBoxProxexp_FormInicioC";
            groupBoxEstado_FormInicioC.Tag = "groupBoxEstado_FormInicioC";
            groupBoxAtencion_FormInicioC.Tag = "groupBoxAtencion_FormInicioC";
            buttonPagar_FormInicioC.Tag = "buttonPagar_FormInicioC";
        }
    }
}
