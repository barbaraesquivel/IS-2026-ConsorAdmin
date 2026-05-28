using BE;
using BLL;
using ConsorAdmin.FORMS_GESTOR_CONSORCIOS;
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
                ConfigurarBotonesSegunPermisos(idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Familia Admin (GE100) tiene: US001, US002, BT001, RP001
        /// Cada botón usa su patente individual → un usuario con solo US002
        /// ve únicamente buttonPermisos, nada más.
        /// </summary>
        private void ConfigurarBotonesSegunPermisos(Guid idUsuario)
        {
            //buttonDashboard buttonGestionUsuarios buttonPermisos buttonEdificiosPorG buttonHistoria buttonGestionarEdificios buttonGestionarUnidades

            buttonDashboard.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);

            buttonGestionUsuarios.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarUsuarios);

            buttonPermisos.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.AsignarRoles);

            buttonHistoria.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.ConsultarBitacora);

            buttonGestionarEdificios.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarConsorcios);

            buttonGestionarUnidades.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarUnidades);

            buttonEdificiosPorG.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarConsorcios);
            /*
            // Dashboard: solo para permisos de administración reales (no solo RP001)
            buttonDashboard.Visible =
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarUsuarios) ||
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.AsignarRoles) ||
                _permisoBLL.TienePatente(idUsuario, CodigosPermiso.ConsultarBitacora);

            // Gestionar usuarios → US001
            buttonGestionUsuarios.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarUsuarios);

            // Asignar roles/permisos → US002
            buttonPermisos.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.AsignarRoles);

            // Bitácora → BT001
            buttonHistoria.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.ConsultarBitacora);

            // Reportes / asignar gestor → RP001
            // (GE100 tiene RP001 como hijo, reutilizamos para estos botones de gestión)
            buttonDashboard.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);
            buttonGestionarEdificios.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);
            button1.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);
            */
        }

        private void Form1Proovedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            activeForm?.Close();
            activeForm?.Dispose();
            activeForm = null;
            panelChildForm.Controls.Clear();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formDashA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonGestionUsuarios_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formGestionUsuariosA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonPermisos_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formPermisosA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonAsignarG_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formEdificiosPorGestorA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formBitacoraA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonGestionarEdificios_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formRegistrarEdificioA()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonGestionarUnidades_Click(object sender, EventArgs e)
        {
            openChildForm(new formGestionarUnidadA());
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm?.Dispose();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            childForm.Location = new Point(0, 0);

            int diff = childForm.Width - panelChildForm.Width;
            this.Width = diff > 0 ? tamañoOriginal.Width + diff : tamañoOriginal.Width;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}