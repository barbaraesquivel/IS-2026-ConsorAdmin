using ABSTRAC;

namespace BE
{
    public class UsuarioBE : IUsuario
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Bloqueado { get; set ; }
        public Guid Id { get; set ; }
        public bool Baja { get; set; }

     

    }
}
