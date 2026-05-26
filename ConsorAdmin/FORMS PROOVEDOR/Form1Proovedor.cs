using BLL;
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
    public partial class Form1Proovedor : Form
    {
        Login formlogin;

        public Form1Proovedor()
        {
            InitializeComponent();
        }
        private void Form1Proovedor_FormClosing(object sender, FormClosingEventArgs e)
        {
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
