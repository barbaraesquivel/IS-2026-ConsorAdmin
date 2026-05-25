using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public static class UsuarioMapper
    {
        public static UsuarioBE ToBE(Usuario model)
        {
            if (model == null) return null;

            return new UsuarioBE
            {
                Id = model.Id,
                Usuario = model.Usuario1,
                Contraseña = model.Contraseña,
                Bloqueado = model.Bloqueado,
                Baja = model.Baja
            };
        }

        public static Usuario ToModel(UsuarioBE be)
        {
            if (be == null) return null;

            return new Usuario
            {
                Id = be.Id,
                Usuario1 = be.Usuario,
                Contraseña = be.Contraseña,
                Bloqueado = be.Bloqueado,
                Baja = be.Baja
            };
        }

        public static UsuarioBE Map(Usuario model) => ToBE(model);
        public static Usuario Map(UsuarioBE be) => ToModel(be);
    }
}
