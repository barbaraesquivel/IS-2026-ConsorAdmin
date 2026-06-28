using BE;

namespace BLL
{
    public interface IUsuarioBLL
    {
        IUsuario Login(string usuario, string contraseña);
    }
}
