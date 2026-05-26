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

namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    public partial class Form1Gestor : Form
    {
        Login formlogin;

        public Form1Gestor()
        {
            InitializeComponent();
        }

        private void Form1Gestor_Load(object sender, EventArgs e)
        {
            this.Hide();
            formlogin = new Login();
            formlogin.ShowDialog();
            buttonCargarExpensas.Visible = false;
            this.Show();
        }

        UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                _usuarioBLL.Logout();
                this.Form1Gestor_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de cierre de sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInicioG());
        }

        private void buttonCargarExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCargarG());

        }

        private void buttonVerEdificios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEdificiosG());

        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHistorialG());

        }

        private void buttonRecaudacion_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRecauG());

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
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
