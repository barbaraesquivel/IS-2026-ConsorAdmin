using BE;
using BLL;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public partial class Form1Consorcista : Form
    {
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private Form activeForm = null;

        public Form1Consorcista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        /// Familia Consorcista (GE300) tiene: EX001, EX002
        /// EX001 = Consultar expensas ? ver expensas
        /// EX002 = Pagar expensa      ? pagar
        /// </summary>
        private void ConfigurarBotonesSegunPermisos(Guid idUsuario)
        {
            buttonInicio.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaConsorcista);
            buttonVerExpensas.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.ConsultarExpensas);
            buttonPagarExpensas.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.PagarExpensa);
        }

        private void Form1Consorcista_FormClosing(object sender, FormClosingEventArgs e)
        {
            activeForm?.Close();
            activeForm?.Dispose();
            activeForm = null;
            panelChildForm.Controls.Clear();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formInicioC()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonPagarExpensas_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formPagarC()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonVerExpensas_Click(object sender, EventArgs e)
        {
            try { openChildForm(new formExpC()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
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