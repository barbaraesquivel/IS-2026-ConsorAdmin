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
    public partial class formPerfilC : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formPerfilC()
        {
            InitializeComponent();
        }

        private void formPerfilC_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formPerfilC_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxDatosContacto_FormPerfilC.Tag = "groupBoxDatosContacto_FormPerfilC";
            buttonGuard_FormPerfilC.Tag = "buttonGuard_FormPerfilC";
            buttonCancelar_FormPerfilC.Tag = "buttonCancelar_FormPerfilC";
            labelLocalidad_FormPerfilC.Tag = "labelLocalidad_FormPerfilC";
            labelConfirmarContraseña_FormPerfilC.Tag = "labelConfirmarContraseña_FormPerfilC";
            labelNuevaContraseña_FormPerfilC.Tag = "labelNuevaContraseña_FormPerfilC";
            labelMail_FormPerfilC.Tag = "labelMail_FormPerfilC";
            labelDireccion_FormPerfilC.Tag = "labelDireccion_FormPerfilC";
            labelTelefono_FormPerfilC.Tag = "labelTelefono_FormPerfilC";
            groupBoxDatosPersonales_FormPerfilC.Tag = "groupBoxDatosPersonales_FormPerfilC";
            labelFechaNac_FormPerfilC.Tag = "labelFechaNac_FormPerfilC";
            labelDNI_FormPerfilC.Tag = "labelDNI_FormPerfilC";
            labelApellido_FormPerfilC.Tag = "labelApellido_FormPerfilC";
            labelNombre_FormPerfilC.Tag = "labelNombre_FormPerfilC";
        }
    }
}
