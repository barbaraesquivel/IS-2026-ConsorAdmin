namespace BE
{
    public interface IUsuario : IEntidad
    {
        string Usuario { get; set; }
        string Contraseña { get; set; }
        bool Bloqueado { get; set; }
        int? IdIdiomaPreferido { get; set; }
    }
}
