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
                .Include(u => u.UsuarioPermisos)
                    .ThenInclude(up => up.IdPermisoNavigation)
                .FirstOrDefault(u => u.Username == nombreUsuario
                                  && u.PasswordHash == passwordHash);
            return UsuarioMapper.Map(model);
        }

        public void ActualizarIdiomaPreferido(Guid idUsuario, int idIdioma)
        {
            using var ctx = new AppDbContext();
            var usuario = ctx.Usuarios.Find(idUsuario);
            if (usuario == null) return;
            usuario.IdIdiomaPreferido = idIdioma;
            ctx.SaveChanges();
        }

        public UsuarioBE ObtenerPorNombre(string nombreUsuario)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios
                .Include(u => u.UsuarioPermisos)
                    .ThenInclude(up => up.IdPermisoNavigation)
                .FirstOrDefault(u => u.Username == nombreUsuario);
            return UsuarioMapper.Map(model);
        }

        public UsuarioBE ObtenerPorId(Guid id)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios.Find(id);
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
        public List<int> ObtenerIdPermisosDeUsuario(Guid idUsuario)
        {
            using var ctx = new AppDbContext();
            return ctx.UsuarioPermisos
                .Where(up => up.IdUsuario == idUsuario)
                .Select(up => up.IdPermiso)
                .ToList();
        }

        public List<UsuarioBE> ObtenerGestores()
        {
         //   int idFamiliaGestores = 12; // Id de la familia "Gestores"

            /*
            using (var context = new AppDbContext())
            {
                return context.Usuarios
                    .Where(u => u.UsuarioPermisos
                        .Any(up => up.IdPermiso == idFamiliaGestores))
                    .Select(u => UsuarioMapper.Map(u))
                    .ToList();
            }
            */
            using (var context = new AppDbContext())
            {
                int idFamilia = context.Permisos
                    .Where(p => p.Codigo == "GE200" && p.Tipo == "F")
                    .Select(p => p.IdPermiso)
                    .First();

                return context.Usuarios
                    .Where(u => u.UsuarioPermisos
                        .Any(up => up.IdPermiso == idFamilia))
                    .Select(u => UsuarioMapper.Map(u))
                    .ToList();
            }
            

            // No se hace Include de UsuarioPermisos porque la columna id_usuario_permiso
            // en la BD es int pero el modelo EF la declara como string (scaffolding legacy).
            // Los permisos de cada usuario se cargan por separado vía PermisoRepositorio.
            /*
            return ctx.Usuarios
                .Where(n => n.UsuarioPermisos.ToList().Exists(Predicate<UsuarioPermiso> "GE200"))
                .Select()
                .ToList();
                .Select(u => UsuarioMapper.Map(u))
                
                .ToList();*/
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
                TipoUsuario = "Operador",
                Email = usuario.Email,
                Telefono = usuario.Telefono
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
            model.Email = usuario.Email;
            model.Telefono = usuario.Telefono;
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
