using BE;
using BLL;
using ConsorAdmin.FORMS_ADMIN;
using ConsorAdmin.FORMS_GESTOR_CONSORCIOS;
using ConsorAdmin.FORMS_PROOVEDOR;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public partial class FormPrincipal : Form
    {
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarBotonesSegunPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarBotonesSegunPermisos()
        {
            var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;

            // Cada botón aparece solo si el usuario tiene ALGUNA patente de esa familia
            // O si tiene la familia completa asignada directamente
            buttonAdmin.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaAdmin);
            buttonGestor.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaGestor);
            buttonConsorcista.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaConsorcista);
            buttonProovedor.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaProveedor);

            if (!buttonAdmin.Visible && !buttonGestor.Visible &&
                !buttonConsorcista.Visible && !buttonProovedor.Visible)
            {
                MessageBox.Show("No tiene perfiles asignados. Contacte al administrador.",
                    "Sin perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _usuarioBLL.Logout();
                this.Close();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1Admin gestor = new Form1Admin())
            {
                gestor.ShowDialog();
            }
            this.Show();
        }

        private void buttonGestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1Gestor gestor = new Form1Gestor())
            {
                gestor.ShowDialog();
            }
            this.Show();
        }

        private void buttonConsorcista_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1Consorcista consorcista = new Form1Consorcista())
            {
                consorcista.ShowDialog();
            }
            this.Show();
        }

        private void buttonProovedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1Proovedor proovedor = new Form1Proovedor())
            {
                proovedor.ShowDialog();
            }
            this.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cerrar sesión?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usuarioBLL.Logout();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
