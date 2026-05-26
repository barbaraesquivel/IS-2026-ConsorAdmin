using Microsoft.VisualBasic.Logging;
using SERV;
using System.Drawing.Text;

namespace ConsorAdmin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
            
            while (true)
            {
                using (Login login = new Login())
                {
                    // Si cierra el login con la X -> cerrar app
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                var usuario = SessionManager.ObtenerInstancia.Usuario;

                Form formPrincipal = null;

                if (Convert.ToString(usuario.Id) == "fb88b9f2-e5a7-4cb9-b73a-d49c313dbc83")
                {
                    formPrincipal = new FormPrincipal();
                }

                // ADMIN
                else if (Convert.ToString(usuario.Id) == "GUID-ADMIN")
                {
                    formPrincipal = new FormPrincipal();
                }
            
                // Si no coincide ningún usuario
                if (formPrincipal == null)
                {
                    MessageBox.Show(
                        "El usuario no tiene un formulario asignado.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    SessionManager.Logout();
                    continue;
                }

                // Abre el form principal
                Application.Run(formPrincipal);

                // Cuando el form se cierra:
                SessionManager.Logout();
           

                /*
                try
                {
                    using var login = new Login();

                    if (login.ShowDialog() != DialogResult.OK)
                        return; // canceló → salimos sin abrir nada

                    // Login exitoso → arrancamos la app principal
                    Application.Run(new Form1());

                    // Cuando se cierra el form principal, cerramos la sesión
                    if (SessionManager.SesionActiva())
                        SessionManager.Logout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error inesperado:\n{ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } */
            }
        }
    }
}