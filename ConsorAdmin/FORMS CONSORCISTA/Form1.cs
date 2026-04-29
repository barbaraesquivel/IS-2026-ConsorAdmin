using System.Security.Policy;

namespace ConsorAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
