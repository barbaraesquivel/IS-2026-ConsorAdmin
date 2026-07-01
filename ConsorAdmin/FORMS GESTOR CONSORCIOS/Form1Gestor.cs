using BE;
using BLL;
using ConsorAdmin.FORMS_ADMIN;
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
    public partial class Form1Gestor : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private Size tamañoOriginal;
        public Form1Gestor()
        {
            InitializeComponent();
            tamañoOriginal = this.Size;

        }

        private void Form1Gestor_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();

            cboIdiomaShell.SelectedIndexChanged -= cboIdiomaShell_SelectedIndexChanged;
            var idiomas = _traductorBLL.ObtenerIdiomas();
            cboIdiomaShell.DataSource = idiomas;
            cboIdiomaShell.DisplayMember = "Nombre";
            cboIdiomaShell.ValueMember = "IdIdioma";
            if (SessionManager.IdiomaActual != null)
                cboIdiomaShell.SelectedValue = SessionManager.IdiomaActual.IdIdioma;
            cboIdiomaShell.SelectedIndexChanged += cboIdiomaShell_SelectedIndexChanged;
        }

        private void Form1Gestor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }
            panelChildForm.Controls.Clear();
        }

        private void cboIdiomaShell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdiomaShell.SelectedItem is not IdiomaBE idioma) return;
            SessionManager.CambiarIdioma(idioma);
            new UsuarioBLL().ActualizarIdiomaPreferido(SessionManager.ObtenerInstancia.Usuario.Id, idioma.IdIdioma);
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
            labelUsername_Form1Gestor.Tag = "labelUsername_Form1Gestor";
            labelSESION_Form1Gestor.Tag = "labelSESION_Form1Gestor";
            buttonHistorial_Form1Gestor.Tag = "buttonHistorial_Form1Gestor";
            buttonVerEdificios_Form1Gestor.Tag = "buttonVerEdificios_Form1Gestor";
            buttonCargarExpensas_Form1Gestor.Tag = "buttonCargarExpensas_Form1Gestor";
            buttonInicio_Form1Gestor.Tag = "buttonInicio_Form1Gestor";
            buttonGestionarUnidades_Form1Gestor.Tag = "buttonGestionarUnidades_Form1Gestor";
            buttonRecaudacion_Form1Gestor.Tag = "buttonRecaudacion_Form1Gestor";
            buttonLogout_Form1Gestor.Tag = "buttonLogout_Form1Gestor";
            labelBienvenida_Form1Gestor.Tag = "labelBienvenida_Form1Gestor";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de cierre de sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInicioG());
        }

        private void buttonCargarExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCargarG());

        }

        private void buttonVerEdificios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteConsorcioG());

        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHistorialG());

        }

        private void buttonRecaudacion_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRecauG());

        }
        private void buttonGestionarUnidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionarUnidadesG());

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            childForm.Location = new Point(0, 0);

            int diferenciaAncho = childForm.Width - panelChildForm.Width;

            if (diferenciaAncho > 0)
            {
                this.Width = tamañoOriginal.Width + diferenciaAncho;
            }
            else
            {
                this.Size = tamañoOriginal;
            }

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
