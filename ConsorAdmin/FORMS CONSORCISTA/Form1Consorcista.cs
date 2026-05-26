using ABSTRAC;
using BLL;
using SERV;
using System.Security.Policy;

namespace ConsorAdmin
{
    public partial class Form1Consorcista : Form
    {
        Login formlogin;
        public Form1Consorcista()
        {
            InitializeComponent();
        }
        private void Form1Consorcista_FormClosing(object sender, FormClosingEventArgs e)
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
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new formInicioC());
        }
        private void buttonPagarExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new formPagarC());

        }
        private void buttonVerExpensas_Click(object sender, EventArgs e)
        {
            openChildForm(new formExpC());

        }
        private void buttonModificarPerfil_Click(object sender, EventArgs e)
        {
            openChildForm(new formPerfilC());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.Hide();

            using (Login formlogin = new Login())
            {
                if (formlogin.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }*/
            /*
            this.Hide();
            formlogin = new Login();
            formlogin.ShowDialog();
            this.Show();*/
        }
    }
}
