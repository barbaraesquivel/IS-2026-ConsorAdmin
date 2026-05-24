using ABSTRAC;
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
        }
        Form1 formulario;

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                IUsuario usuario = _usuarioBLL.Login(
                    txtUser.Text.Trim(),
                    txtContraseña.Text);

                SessionManager.Login(usuario);

  
                this.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de inicio de sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var repo = new DAL.Repositorio.UsuarioRepositorio();

                // Verificamos que no exista ya
                if (repo.ObtenerPorNombre("admin") != null)
                {
                    MessageBox.Show("El usuario 'admin' ya existe.", "Aviso");
                    return;
                }

                var nuevoAdmin = new BE.UsuarioBE
                {
                    Id = Guid.NewGuid(),
                    Usuario = "admin",
                    Contraseña = BLL.UsuarioBLL.Hashear("admin1234"),
                    Bloqueado = false,
                    Baja = false
                };

                repo.Crear(nuevoAdmin);

                MessageBox.Show(
                    "Usuario admin creado correctamente.\n\nUsuario: admin\nContraseña: admin1234",
                    "Listo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear admin:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
