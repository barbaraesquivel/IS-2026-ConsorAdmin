using BE;
using BLL;
using SERV;
using System.Linq;

namespace ConsorAdmin
{
    internal static class Program
    {
        // Resultado de la verificación silenciosa al arrancar; se consulta post-login.
        private static ResultadoVerificacion _resultadoIntegridad;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Verificar integridad EN SILENCIO al arrancar; ningún popup aquí.
            _resultadoIntegridad = VerificarEnSilencio();

            while (true)
            {
                using (Login login = new Login())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                // Usuario autenticado → decidir destino según integridad + rol
                var usuario   = SessionManager.ObtenerInstancia.Usuario as UsuarioBE;
                bool integOk  = _resultadoIntegridad == null || _resultadoIntegridad.Ok;

                if (integOk)
                {
                    // Integridad OK (o BD no disponible al arrancar): acceso normal
                    Application.Run(new FormPrincipal());
                }
                else
                {
                    bool esAdmin = usuario?.usuarioPermisos
                        ?.Any(p => p.permisoBE?.Codigo == "GE100") == true;

                    if (esAdmin)
                    {
                        // Admin: panel de recuperación (ya autenticado, sin mini-login)
                        using (var panel = new formRecuperacionAdmin(usuario.Id))
                            panel.ShowDialog();

                        // Re-verificar tras la intervención del admin
                        _resultadoIntegridad = VerificarEnSilencio();

                        if (_resultadoIntegridad == null || _resultadoIntegridad.Ok)
                        {
                            // Integridad restaurada: permitir acceso normal en esta misma sesión
                            Application.Run(new FormPrincipal());
                        }
                        // else: integridad aún comprometida → vuelve al while → login de nuevo
                    }
                    else
                    {
                        // Usuario común: mensaje genérico sin detalles técnicos
                        MessageBox.Show(
                            "Ha habido un problema con el sistema. Contacte al administrador.",
                            "Acceso no disponible",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

                if (SessionManager.SesionActiva())
                    SessionManager.Logout();
            }
        }

        // Ejecuta VerificarIntegridad() sin mostrar ningún popup.
        // Retorna null si la BD no está disponible (se tratará como integridad OK).
        private static ResultadoVerificacion VerificarEnSilencio()
        {
            try
            {
                return new VerificadorBLL().VerificarIntegridad();
            }
            catch
            {
                return null;
            }
        }

        static void Main_old_code_commented()
        {
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