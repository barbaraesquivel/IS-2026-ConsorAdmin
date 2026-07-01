using BE;
using BLL;
using DAL.Models;
using SERV;
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
    public partial class Login : Form, IIdiomaObserver
    {
        private readonly IUsuarioBLL _usuarioBLL;
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();

        public Login()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            timer1.Tick += timer1_Tick;

        }

        private int intentosFallidos = 0;
        private int limiteIntentos = 3;
        private static int tiempoBloqueoSeg = 5; //segundos
        private static int tiempoRestante = 0;

        private void Login_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);

            cboIdiomaPreLogin.SelectedIndexChanged -= cboIdiomaPreLogin_SelectedIndexChanged;
            var idiomas = _traductorBLL.ObtenerIdiomas();
            cboIdiomaPreLogin.DataSource = idiomas;
            cboIdiomaPreLogin.DisplayMember = "Nombre";
            cboIdiomaPreLogin.ValueMember = "IdIdioma";
            var defaultIdioma = idiomas.FirstOrDefault(i => i.EsDefault);
            if (defaultIdioma != null) cboIdiomaPreLogin.SelectedValue = defaultIdioma.IdIdioma;
            cboIdiomaPreLogin.SelectedIndexChanged += cboIdiomaPreLogin_SelectedIndexChanged;

            Traducir();
        }

        private void cboIdiomaPreLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdiomaPreLogin.SelectedItem is IdiomaBE idioma)
                SessionManager.CambiarIdioma(idioma); // traduce el login sin necesitar estar logueado
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
            labelUsuario_FormLogin.Tag = "labelUsuario_FormLogin";
            labelContraseña_FormLogin.Tag = "labelContraseña_FormLogin";
            btnIniciaSesion_FormLogin.Tag = "btnIniciaSesion_FormLogin";
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuario usuario = _usuarioBLL.Login(
                    txtUser.Text.Trim(),
                    txtContraseña.Text);

                SessionManager.Login(usuario);

                // --- Acá va el código de idioma ---
                var traductorBLL = new TraductorBLL();
                IdiomaBE idiomaUsuario = usuario.IdIdiomaPreferido.HasValue
                    ? traductorBLL.ObtenerIdiomaPorId(usuario.IdIdiomaPreferido.Value)
                    : traductorBLL.ObtenerIdiomaDefault();

                SessionManager.CambiarIdioma(idiomaUsuario);
                // --- fin código de idioma ---
                intentosFallidos = 0;
                this.DialogResult = DialogResult.OK;
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de inicio de sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                intentosFallidos++;
                if (intentosFallidos >= limiteIntentos)
                {
                    MessageBox.Show("Has superado los 5 intentos de Inicio de sesion con fallidos.\nVuelva en 5min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tiempoRestante = tiempoBloqueoSeg;
                    btnIniciaSesion_FormLogin.Enabled = false;
                    txtUser.Enabled = false;
                    txtContraseña.Enabled = false;

                    timer1.Interval = 1000;


                    timer1.Start();
                }

                txtContraseña.Clear();
                txtContraseña.Focus();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (tiempoRestante > 0)
            {
                tiempoRestante--;
            }
            else
            {
                // El tiempo de bloqueo terminó
                timer1.Stop();
                btnIniciaSesion_FormLogin.Enabled = true;
                txtUser.Enabled = true;
                txtContraseña.Enabled = true;
                intentosFallidos = 0; // Reinicia los intentos fallidos
            }
        }
        
        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
             
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
            //Application.Exit();
        }
    }

}
