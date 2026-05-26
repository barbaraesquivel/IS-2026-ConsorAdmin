using ABSTRAC;
namespace SERV
{
    public class SessionManager
    {
        private static SessionManager instancia;
        private static readonly object _lock = new object();

        public IUsuario Usuario { get; private set; }
        public DateTime FechaInicio { get; private set; }

        private SessionManager() { }

        public static SessionManager ObtenerInstancia
        {
            get
            {
                if (instancia == null) throw new Exception("Sesión no iniciada");
                return instancia;
            }
        }


        public static bool SesionActiva()
        {
            lock (_lock) { return instancia != null; }
        }

        public static void Login(IUsuario usuario)
        {
            lock (_lock)
            {
                if (instancia != null)
                    throw new Exception("Sesión ya iniciada");

                instancia = new SessionManager
                {
                    Usuario = usuario,
                    FechaInicio = DateTime.Now
                };
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (instancia == null)
                    throw new Exception("Sesión no iniciada");
                instancia = null;
            }
        }

    }
}
