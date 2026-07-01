using BE;
using System;

namespace BLL
{
    public interface IUsuarioBLL
    {
        IUsuario Login(string usuario, string contraseña);
        void ActualizarIdiomaPreferido(Guid idUsuario, int idIdioma);
    }
}
