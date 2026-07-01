using BE;
namespace SERV
{
    public class SessionManager
    {
        private static SessionManager instancia;
        private static readonly object _lock = new object();
        // — campos nuevos (privados, dentro de la clase) —
        private static readonly List<IIdiomaObserver> _observers = new();
        private static IdiomaBE _idiomaActual;

        // — propiedades nuevas —
        public static IdiomaBE IdiomaActual => _idiomaActual;

        
        public IUsuario Usuario { get; private set; }
        public DateTime FechaInicio { get; private set; }

        private SessionManager() { }

        public static SessionManager ObtenerInstancia
        {
            get
            {
                lock (_lock)
                {
                    if (instancia == null) throw new Exception("Sesión no iniciada");
                    return instancia;
                }
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
                _observers.Clear();
                _idiomaActual = null;
            }
        }
        // — métodos nuevos —
        public static void SuscribirObservador(IIdiomaObserver o)
        {
            lock (_lock) { if (!_observers.Contains(o)) _observers.Add(o); }
        }

        public static void DesuscribirObservador(IIdiomaObserver o)
        {
            lock (_lock) { _observers.Remove(o); }
        }

        public static void CambiarIdioma(IdiomaBE idioma)
        {
            lock (_lock) { _idiomaActual = idioma; }
            foreach (var o in _observers)
                o.ActualizarIdioma(idioma);
        }
    }
}
