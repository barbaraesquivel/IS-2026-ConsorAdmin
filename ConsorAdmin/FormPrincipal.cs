using BE;
using BLL;
using ConsorAdmin.FORMS_ADMIN;
using ConsorAdmin.FORMS_GESTOR_CONSORCIOS;
using ConsorAdmin.FORMS_PROOVEDOR;
using SERV;
using System;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public partial class FormPrincipal : Form, IIdiomaObserver
    {
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();

            try
            {
                MostrarBotonesSegunPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        public void ActualizarIdioma(IdiomaBE idioma)
        {
            if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
            else Traducir(idioma);
        }

        private void Traducir(IdiomaBE idioma = null)
        {
            idioma ??= SessionManager.IdiomaActual ?? _traductorBLL.ObtenerIdiomaDefault();
            var t = _traductorBLL.ObtenerTraducciones(idioma);
            TraducirControles(this.Controls, t);
        }

        private void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> t)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl.Tag is string clave && t.ContainsKey(clave))
                    ctrl.Text = t[clave];
                if (ctrl.Controls.Count > 0)
                    TraducirControles(ctrl.Controls, t);
            }
        }

        private void AsignarTags()
        {
            buttonAdmin_FormPrincipal.Tag = "buttonAdmin_FormPrincipal";
            buttonGestor_FormPrincipal.Tag = "buttonGestor_FormPrincipal";
            buttonConsorcista_FormPrincipal.Tag = "buttonConsorcista_FormPrincipal";
            buttonProovedor_FormPrincipal.Tag = "buttonProovedor_FormPrincipal";
            buttonLogout_FormPrincipal.Tag = "buttonLogout_FormPrincipal";
        }

        private void MostrarBotonesSegunPermisos()
        {
            var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;

            buttonAdmin_FormPrincipal.Visible       = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaAdmin);
            buttonGestor_FormPrincipal.Visible      = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaGestor);
            buttonConsorcista_FormPrincipal.Visible = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaConsorcista);
            buttonProovedor_FormPrincipal.Visible   = _permisoBLL.TieneAlgunaPatenteDeFamilia(idUsuario, CodigosPermiso.FamiliaProveedor);

            if (!buttonAdmin_FormPrincipal.Visible && !buttonGestor_FormPrincipal.Visible &&
                !buttonConsorcista_FormPrincipal.Visible && !buttonProovedor_FormPrincipal.Visible)
            {
                MessageBox.Show("No tiene perfiles asignados. Contacte al administrador.",
                    "Sin perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SessionManager.Logout();
                this.Close();
            }
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
                if (MessageBox.Show("¿Desea cerrar sesión?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usuarioBLL.Logout();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
