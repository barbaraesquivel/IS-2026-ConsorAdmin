using BE;
using System;
using System.Collections.Generic;

namespace DAL.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioBE ObtenerPorCredenciales(string nombreUsuario, string passwordHash);
        UsuarioBE ObtenerPorNombre(string nombreUsuario);
        UsuarioBE ObtenerPorId(Guid id);
        List<UsuarioBE> ObtenerTodos();
        void Crear(UsuarioBE usuario);
        void Actualizar(UsuarioBE usuario);
        void Inactivar(Guid idUsuario);
        List<PermisoBE> ObtenerTodosPermisos();
        void ActualizarPermisosDeUsuario(Guid idUsuario, List<int> nuevosPermisos);
        void ActualizarIdiomaPreferido(Guid idUsuario, int idIdioma);

        List<UsuarioBE> ObtenerGestores();
    }
}
