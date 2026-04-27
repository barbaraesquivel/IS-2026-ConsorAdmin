using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IUsuarioRepositorio
    {
        UsuarioBE ObtenerPorCredenciales(string nombreUsuario, string passwordHash);
        UsuarioBE ObtenerPorNombre(string nombreUsuario);
        void Crear(UsuarioBE usuario);
        void Actualizar(UsuarioBE usuario);
    }
}
