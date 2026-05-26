using ABSTRAC;
using BE;
using BLL;
using ConsorAdmin.FORMS_ADMIN;
using ConsorAdmin.FORMS_GESTOR_CONSORCIOS;
using ConsorAdmin.FORMS_PROOVEDOR;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            MostrarBotonesSegunPermisos();
        }

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private void MostrarBotonesSegunPermisos()
        {
            // Obtener usuario actual
            IUsuario usuario = SessionManager.ObtenerInstancia.Usuario;

            // Lógica de ejemplo: supongamos que el usuario tiene una lista de permisos (strings)
            // o una propiedad "Rol". Ajustala según tu modelo real.
            var permisos = usuario.Usuario;  // List<string> o algo similar

            //buttonAdmin.Visible = permisos.Contains("Admin");
            //buttonGestor.Visible = permisos.Contains("Gestor");
            //buttonConsorcista.Visible = permisos.Contains("Consorcista");
            //buttonProovedor.Visible = permisos.Contains("Proveedor");

            // Opcional: si ningún botón visible, podrías mostrar un mensaje y cerrar sesión.
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
                // Preguntar si está seguro
                if (MessageBox.Show("¿Desea cerrar sesión?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usuarioBLL.Logout();
                    this.Close();
                }
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
