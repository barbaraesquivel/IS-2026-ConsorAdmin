using BE;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public UsuarioBE ObtenerPorCredenciales(string nombreUsuario, string passwordHash)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios
                .FirstOrDefault(u => u.Username == nombreUsuario
                                  && u.PasswordHash == passwordHash);
            return UsuarioMapper.Map(model);
        }

        public UsuarioBE ObtenerPorNombre(string nombreUsuario)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios
                .FirstOrDefault(u => u.Username == nombreUsuario);
            return UsuarioMapper.Map(model);
        }


        public List<UsuarioBE> ObtenerTodos()
        {
            using var ctx = new AppDbContext();
            // No se hace Include de UsuarioPermisos porque la columna id_usuario_permiso
            // en la BD es int pero el modelo EF la declara como string (scaffolding legacy).
            // Los permisos de cada usuario se cargan por separado vía PermisoRepositorio.
            return ctx.Usuarios
                .Select(u => UsuarioMapper.Map(u))
                .ToList();
        }

        public void Crear(UsuarioBE usuario)
        {
            using var ctx = new AppDbContext();
            if (usuario.Id == Guid.Empty)
                usuario.Id = Guid.NewGuid();

            var model = new Usuario
            {
                IdUsuario = usuario.Id,
                Username = usuario.Usuario,
                PasswordHash = usuario.Contraseña,
                Bloqueado = usuario.Bloqueado,
                Activo = !usuario.Baja,
                TipoUsuario = "Operador"
            };
            ctx.Usuarios.Add(model);
            ctx.SaveChanges();
        }

        public void Actualizar(UsuarioBE usuario)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios.Find(usuario.Id);
            if (model == null) return;

            model.Username = usuario.Usuario;
            model.PasswordHash = usuario.Contraseña;
            model.Bloqueado = usuario.Bloqueado;
            model.Activo = !usuario.Baja;
            ctx.SaveChanges();
        }

        public void Inactivar(Guid idUsuario)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios.Find(idUsuario);
            if (model == null) return;

            model.Activo = false;
            ctx.SaveChanges();
        }

        public List<PermisoBE> ObtenerTodosPermisos()
        {
            using var ctx = new AppDbContext();
            return ctx.Permisos
                .Select(p => new PermisoBE
                {
                    Id_Permiso = p.IdPermiso,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Tipo = p.Tipo,
                    usuarioPermisos = new List<UsuarioPermisoBE>()
                })
                .ToList();
        }

        public void ActualizarPermisosDeUsuario(Guid idUsuario, List<int> nuevosPermisos)
        {
            using var ctx = new AppDbContext();

            var existentes = ctx.UsuarioPermisos
                .Where(up => up.IdUsuario == idUsuario)
                .ToList();
            ctx.UsuarioPermisos.RemoveRange(existentes);

            foreach (var idPermiso in nuevosPermisos)
            {
                ctx.UsuarioPermisos.Add(new UsuarioPermiso
                {
                    IdUsuario = idUsuario,
                    IdPermiso = idPermiso
                });
            }
            ctx.SaveChanges();
        }
    }
}
