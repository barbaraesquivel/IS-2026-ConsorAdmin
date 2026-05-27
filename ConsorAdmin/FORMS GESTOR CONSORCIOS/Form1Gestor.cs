using BLL;
using ConsorAdmin.FORMS_ADMIN;
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
        private Size tamañoOriginal;
        public Form1Gestor()
        {
            InitializeComponent();
            tamañoOriginal = this.Size;

        }

        private void Form1Gestor_Load(object sender, EventArgs e)
        {

        }

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
        private void buttonGestionarUnidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionarUnidadesG());

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
            childForm.Dock = DockStyle.None;
            childForm.Location = new Point(0, 0);

            int diferenciaAncho = childForm.Width - panelChildForm.Width;

            if (diferenciaAncho > 0)
            {
                this.Width = tamañoOriginal.Width + diferenciaAncho;
            }
            else
            {
                this.Size = tamañoOriginal;
            }

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
