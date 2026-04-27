using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class UsuarioRepositorio :IUsuarioRepositorio
    {
        public UsuarioBE ObtenerPorCredenciales(string nombreUsuario, string passwordHash)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario
                                  && u.Contraseña == passwordHash);
            return UsuarioMapper.ToBE(model);
        }

        public UsuarioBE ObtenerPorNombre(string nombreUsuario)
        {
            using var ctx = new AppDbContext();
            var model = ctx.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            return UsuarioMapper.ToBE(model);
        }

        public void Crear(UsuarioBE usuario)
        {
            using var ctx = new AppDbContext();
            var model = UsuarioMapper.ToModel(usuario);
            ctx.Usuarios.Add(model);
            ctx.SaveChanges();
        }

        public void Actualizar(UsuarioBE usuario)
        {
            using var ctx = new AppDbContext();
            var model = UsuarioMapper.ToModel(usuario);
            ctx.Usuarios.Update(model);
            ctx.SaveChanges();
        }
    }
}
