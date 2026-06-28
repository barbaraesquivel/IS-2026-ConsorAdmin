namespace BE
{
    public class UsuarioBE : IUsuario
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Bloqueado { get; set ; }
        public Guid Id { get; set ; }
        public bool Baja { get; set; }
        public ConsorcistaBE consorcistaBE { get; set; }
        public ProovedorBE proovedorBE { get; set; }
        public List<GestorConsorcioBE> gestorConsorcioBEs { get; set; }
        public List<LogBitacoraBE> logBitacoras { get; set; }
        public List<UsuarioPermisoBE> usuarioPermisos { get; set; }


    }
}
