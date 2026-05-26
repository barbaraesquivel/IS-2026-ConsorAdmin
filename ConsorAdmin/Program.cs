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

            while (true)
            {
                using (Login login = new Login())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                var usuario = SessionManager.ObtenerInstancia.Usuario;

                // Aquí podrías validar roles para mostrar un menú diferente,
                // pero como todos usan FormPrincipal (intermedia) no hace falta.
                FormPrincipal formPrincipal = new FormPrincipal();
                Application.Run(formPrincipal);

                if (SessionManager.SesionActiva())
                    SessionManager.Logout();
            }
            /*
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

                if (Convert.ToString(usuario.Id) == "c6e418f5-2381-4c5e-8926-1e5592b04b68")
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
                } 
                
            }
            */
        }
    }
}