using BE;
using BLL;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    public partial class Form1Gestor : Form
    {
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private Form activeForm = null;
        private Size tamañoOriginal;

        public Form1Gestor()
        {
            InitializeComponent();
            tamañoOriginal = this.Size;
        }

        private void Form1Gestor_Load(object sender, EventArgs e)
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
        /// Familia Gestor (GE200) tiene: EX003, SV003, RP001
        /// EX003 = Liquidar expensas → cargar/liquidar
        /// SV003 = Aprobar servicio  → ver/gestionar servicios
        /// RP001 = Generar reportes  → historial, recaudación, morosidad
        /// </summary>
        private void ConfigurarBotonesSegunPermisos(Guid idUsuario)
        {
            // Inicio: visible si tiene cualquier patente de Gestor
            //buttonInicio.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaGestor);

            // Ver/editar edificios → EX003 (el gestor liquida para sus consorcios)
            buttonVerEdificios.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GestionarConsorcios);

            // Gestionar unidades → EX003
//            buttonGestionarUnidades.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.LiquidarExpensas);

            // Cargar/liquidar expensas → EX003
            buttonCargarExpensas.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.LiquidarExpensas);

            // Historial expensas → SV003 o RP001
            buttonHistorial.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.AprobarServicio)
                                   || _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);

            // Recaudación → RP001
            buttonRecaudacion.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);

            // Morosidad → RP001
            buttonReportes.Visible = _permisoBLL.TienePatente(idUsuario, CodigosPermiso.GenerarReportes);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormReportesG()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonCargarExpensas_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormCargarG()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonVerEdificios_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormEditarConsorcioG()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormHistorialG()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void buttonRecaudacion_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormRecauG()); }
            catch (Exception ex) { MostrarError(ex); }
        }


        private void buttonMorosidad_Click(object sender, EventArgs e)
        {
            try { openChildForm(new FormReportesG()); }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm?.Dispose();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            childForm.Location = new Point(0, 0);

            int diff = childForm.Width - panelChildForm.Width;
            this.Width = diff > 0 ? tamañoOriginal.Width + diff : tamañoOriginal.Width;

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