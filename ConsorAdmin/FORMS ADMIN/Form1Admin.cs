using BE;
using BLL;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class Form1Admin : Form, IIdiomaObserver
    {
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private Form activeForm = null;
        private Size tamañoOriginal;

        public Form1Admin()
        {
            InitializeComponent();
            this.Load += Form1Admin_Load;
            tamañoOriginal = this.Size;
        }

        private void Form1Admin_Load(object sender, EventArgs e)
        {
            try
            {
                var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;
                labelUsername_Form1Admin.Text = SessionManager.ObtenerInstancia.Usuario.Usuario;

                PermisoHelper.AplicarPermiso(buttonGestionUsuarios, CodigosPermiso.GestionarUsuarios, idUsuario, _permisoBLL);
                PermisoHelper.AplicarPermiso(buttonPermisos, CodigosPermiso.AsignarRoles, idUsuario, _permisoBLL);
                PermisoHelper.AplicarPermiso(buttonBitacora, CodigosPermiso.ConsultarBitacora, idUsuario, _permisoBLL);

                // Botones huérfanos — siempre visibles, sin patente asignada aún
                // TODO: pendiente definir patente para buttonDashboard
                // TODO: pendiente definir patente para buttonAsignarG
                // TODO: pendiente definir patente para buttonListaConsorcios
                // TODO: pendiente definir patente para buttonCargarExp
                // TODO: pendiente definir patente para buttonRegistrarConsorcio
                SessionManager.SuscribirObservador(this);
                Traducir(); // traduce con el idioma actual de sesión apenas abre

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }
            panelChildForm.Controls.Clear();
        }

        private void buttonGestionUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new formGestionUsuariosA());
        }

        private void buttonPermisos_Click(object sender, EventArgs e)
        {
            openChildForm(new formPermisosA());
        }

        private void buttonAsignarG_Click(object sender, EventArgs e)
        {
            openChildForm(new formAsignarGestorA());
        }

        private void buttonListaConsorcios_Click(object sender, EventArgs e)
        {
            openChildForm(new formEdificiosA());
        }

        private void buttonCargarExp_Click(object sender, EventArgs e)
        {
            openChildForm(new formCargarExpA());
        }

        private void buttonBitacora_Click(object sender, EventArgs e)
        {
            openChildForm(new formBitacoraA());
        }
        private void buttonGestionarEdificios_Click(object sender, EventArgs e)
        {
            openChildForm(new formRegistrarEdificioA());

        }
        private void buttonAgregarIdiomas_Click(object sender, EventArgs e)
        {
            openChildForm(new formIdiomasA());

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

        private void buttonDashboardA_Click(object sender, EventArgs e)
        {
            openChildForm(new formDashA());

        }

        public void ActualizarIdioma(IdiomaBE idioma)
        {
            if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
            else Traducir(idioma);
        }
        private void Traducir(IdiomaBE idioma = null)
        {
            try
            {
                idioma ??= SessionManager.IdiomaActual ?? _traductorBLL.ObtenerIdiomaDefault();
                var t = _traductorBLL.ObtenerTraducciones(idioma);
                TraducirControles(this.Controls, t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message);
            }
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
    }
}
