using BE;
using ConsorAdmin.FORMS_GESTOR_CONSORCIOS;
using ConsorAdmin.FORMS_PROOVEDOR;
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
            ValidarPermisos();
            buttonAdmin.Visible = false;
        }

        UsuarioPermisoBE usuarioPermiso = new UsuarioPermisoBE();
        private void ValidarPermisos()
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Form form = new Form1Gestor();
            form.ShowDialog();

        }

        private void buttonGestor_Click(object sender, EventArgs e)
        {
            Form form = new Form1Gestor();
            form.ShowDialog();

        }

        private void buttonConsorcista_Click(object sender, EventArgs e)
        {
            Form form = new Form1Consorcista();
            form.ShowDialog();


        }

        private void buttonProovedor_Click(object sender, EventArgs e)
        {
            Form form = new Form1Proovedor();
            form.ShowDialog();


        }


    }
}
