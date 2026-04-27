using SERV;

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
    }
}