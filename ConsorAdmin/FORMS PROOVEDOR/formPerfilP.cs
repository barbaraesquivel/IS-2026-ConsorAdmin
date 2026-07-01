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
    public partial class formPerfilP : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public formPerfilP()
        {
            InitializeComponent();
        }

        private void formPerfilP_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
        }

        private void formPerfilP_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxDatos_FormPerfilP.Tag = "groupBoxDatos_FormPerfilP";
            labelFecha_FormPerfilP.Tag = "labelFecha_FormPerfilP";
            labelDNI_FormPerfilP.Tag = "labelDNI_FormPerfilP";
            labelApellido_FormPerfilP.Tag = "labelApellido_FormPerfilP";
            labelNombre_FormPerfilP.Tag = "labelNombre_FormPerfilP";
            groupBoxContacto_FormPerfilP.Tag = "groupBoxContacto_FormPerfilP";
            buttonGuardar_FormPerfilP.Tag = "buttonGuardar_FormPerfilP";
            buttonCanc_FormPerfilP.Tag = "buttonCanc_FormPerfilP";
            labelLocalidad_FormPerfilP.Tag = "labelLocalidad_FormPerfilP";
            labelConfirmarContra_FormPerfilP.Tag = "labelConfirmarContra_FormPerfilP";
            labelNuevaContraseña_FormPerfilP.Tag = "labelNuevaContraseña_FormPerfilP";
            labelEmail_FormPerfilP.Tag = "labelEmail_FormPerfilP";
            labelDireccion_FormPerfilP.Tag = "labelDireccion_FormPerfilP";
            labelTelefono_FormPerfilP.Tag = "labelTelefono_FormPerfilP";
        }
    }
}
