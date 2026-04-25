using ABSTRAC;
namespace SERV
{
    public class SessionManager
    {
        private static SessionManager instancia;
        public static object _lock = new object();

        public IUsuario Usuario { get; set; }
        public DateTime fechaInicio { get; set; }

        public static SessionManager ObtenerInstancia
        {
            get
            {
                if (instancia == null) throw new Exception("Sesion no iniciada");

                return instancia;
            }
        }


        public static void Login(IUsuario usuario)
        {
            lock (_lock)
            {

                if (instancia == null)
                {
                    instancia = new SessionManager();
                    instancia.Usuario = usuario;
                    instancia.fechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (instancia != null)
                {
                    instancia = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }

        private SessionManager()
        {
        }

    }
}
