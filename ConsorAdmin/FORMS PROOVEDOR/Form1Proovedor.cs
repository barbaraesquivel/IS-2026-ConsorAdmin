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
    public partial class Form1Proovedor : Form, IIdiomaObserver
    {
        Login formlogin;
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public Form1Proovedor()
        {
            InitializeComponent();
        }
        private void Form1Proovedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);

            // Cerrar y liberar el formulario activo si existe
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }

            // Limpiar el panel de controles
            panelChildForm.Controls.Clear();
        }
        UsuarioBLL _usuarioBLL = new UsuarioBLL();

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
        private void Form1Proovedor_Load(object sender, EventArgs e)
        {
            /*
            this.Hide();
            formlogin = new Login();
            formlogin.ShowDialog();
            this.Show();*/

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
            labelUsername_Form1Proovedor.Tag = "labelUsername_Form1Proovedor";
            labelSESION_Form1Proovedor.Tag = "labelSESION_Form1Proovedor";
            labelBienvenida_Form1Proovedor.Tag = "labelBienvenida_Form1Proovedor";
            buttonLogout_Form1Proovedor.Tag = "buttonLogout_Form1Proovedor";
            buttonModificarPerfil_Form1Proovedor.Tag = "buttonModificarPerfil_Form1Proovedor";
            buttonVerServicios_Form1Proovedor.Tag = "buttonVerServicios_Form1Proovedor";
            buttonCargar_Form1Proovedor.Tag = "buttonCargar_Form1Proovedor";
            buttonInicio_Form1Proovedor.Tag = "buttonInicio_Form1Proovedor";
        }
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new formInicioP());
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            openChildForm(new formCargarP());
        }

        private void buttonVerServicios_Click(object sender, EventArgs e)
        {
            openChildForm(new formVerP());
        }

        private void buttonModificarPerfil_Click(object sender, EventArgs e)
        {
            openChildForm(new formPerfilP());
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
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
