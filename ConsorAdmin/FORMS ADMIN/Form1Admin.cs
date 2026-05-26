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

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class Form1Admin : Form
    {
        public Form1Admin()
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
            openChildForm(new formHistoriaA());

        }
        UsuarioBLL _usuarioBLL = new UsuarioBLL();

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
