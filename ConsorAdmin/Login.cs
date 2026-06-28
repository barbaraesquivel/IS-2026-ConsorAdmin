using BE;
using BLL;
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
    public partial class Login : Form
    {
        private readonly IUsuarioBLL _usuarioBLL;
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
        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuario usuario = _usuarioBLL.Login(
                    txtUser.Text.Trim(),
                    txtContraseña.Text);

                SessionManager.Login(usuario);
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
                    btnIniciaSesion.Enabled = false;
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
                btnIniciaSesion.Enabled = true;
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
            //Application.Exit();
        }
    }

}
