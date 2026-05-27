using BE;
using BLL;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class Form1Admin : Form
    {
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
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
                labelUsername.Text = SessionManager.ObtenerInstancia.Usuario.Usuario;

                // Botones con patente definida
                PermisoUIHelper.AplicarPermisos(idUsuario, _permisoBLL,
                    (buttonGestionUsuarios, CodigosPermiso.GestionarUsuarios),  // US001
                    (buttonPermisos, CodigosPermiso.AsignarRoles),       // US002
                    (buttonHistoria, CodigosPermiso.ConsultarBitacora)   // BT001
                );

                // Botones huérfanos — siempre visibles, sin patente asignada aún
                // TODO: pendiente definir patente para buttonDashboard
                // TODO: pendiente definir patente para buttonAsignarG
                // TODO: pendiente definir patente para buttonListaConsorcios
                // TODO: pendiente definir patente para buttonCargarExp
                // TODO: pendiente definir patente para buttonRegistrarConsorcio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1Proovedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }
            panelChildForm.Controls.Clear();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new formDashA());
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

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            openChildForm(new formBitacoraA());
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

        private void buttonGestionarEdificios_Click(object sender, EventArgs e)
        {
            openChildForm(new formRegistrarEdificioA());

        }
    }
}
