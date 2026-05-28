using BE;
using BLL;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_PROOVEDOR
{
    public partial class Form1Proovedor : Form
    {
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private Form activeForm = null;

        public Form1Proovedor()
        {
            InitializeComponent();
        }

        private void Form1Proovedor_Load(object sender, EventArgs e)
        {
            try
            {
                var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;
                ConfigurarBotonesSegunPermisos(idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Familia Proveedor (GE400) tiene: SV001, SV002
        /// SV001 = Cargar servicio   → cargar y ver servicios
        /// SV002 = Adjuntar factura  → adjuntar
        /// </summary>
        private void ConfigurarBotonesSegunPermisos(Guid idUsuario)
        {
            buttonInicio.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaProveedor);
            buttonVerServicios.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.CargarServicio);
            buttonCargar.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.CargarServicio);
        }

        private void Form1Proovedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            activeForm?.Close();
            activeForm?.Dispose();
            activeForm = null;
            panelChildForm.Controls.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formInicioP()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formCargarP()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonVerServicios_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formVerP()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm?.Dispose();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
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