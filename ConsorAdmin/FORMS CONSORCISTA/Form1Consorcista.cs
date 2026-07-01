using BE;
using BLL;
using SERV;
using System.Security.Policy;

namespace ConsorAdmin
{
    public partial class Form1Consorcista : Form, IIdiomaObserver
    {
        Login formlogin;
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        public Form1Consorcista()
        {
            InitializeComponent();
        }
        private void Form1Consorcista_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado

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
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new formInicioC());
        }
        private void buttonPagarExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new formPagarC());

        }
        private void buttonVerExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new formExpC());

        }
        private void buttonModificarPerfil_Click(object sender, EventArgs e)
        {
            openChildForm(new formPerfilC());
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
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

                /*
                _usuarioBLL.Logout();
                this.Form1_Load(sender, e);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de cierre de sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            /*
            this.Hide();

            using (Login formlogin = new Login())
            {
                if (formlogin.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }*/
            /*
            this.Hide();
            formlogin = new Login();
            formlogin.ShowDialog();
            this.Show();*/
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
            buttonLogout_Form1Consorcista.Tag = "buttonLogout_Form1Consorcista";
            buttonModificarPerfil_Form1Consorcista.Tag = "buttonModificarPerfil_Form1Consorcista";
            buttonVerExpensas_Form1Consorcista.Tag = "buttonVerExpensas_Form1Consorcista";
            buttonPagarExpensas_Form1Consorcista.Tag = "buttonPagarExpensas_Form1Consorcista";
            buttonInicio_Form1Consorcista.Tag = "buttonInicio_Form1Consorcista";
            labelUsername_Form1Consorcista.Tag = "labelUsername_Form1Consorcista";
            labelSESION_Form1Consorcista.Tag = "labelSESION_Form1Consorcista";
            labelBienvenida_Form1Consorcista.Tag = "labelBienvenida_Form1Consorcista";
        }
    }
}
