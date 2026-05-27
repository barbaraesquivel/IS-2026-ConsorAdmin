using BE;
using DAL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConsorcioBLL
    {
        private readonly ConsorcioDAL _consorcioDAL = new ConsorcioDAL();

        // CU06 - Obtener consorcios según el usuario de sesión
        public List<ConsorcioBE> ObtenerConsorcios()
        {
            try
            {
                var usuario = (BE.UsuarioBE)SessionManager.ObtenerInstancia.Usuario;
                bool esAdmin = usuario.usuarioPermisos
                    .Exists(p => p.permisoBE?.Codigo == "GE100");

                return esAdmin
                    ? _consorcioDAL.ObtenerTodos()
                    : _consorcioDAL.ObtenerPorGestor(usuario.Id);
            }
            catch { throw; }
        }
        public List<ConsorcioBE> ObtenerTodos()
        {
            try
            {
                return _consorcioDAL.ObtenerTodos();
            }
            catch { throw; }
        }
        public ConsorcioBE ObtenerPorId(string idConsorcio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idConsorcio))
                    throw new ArgumentException("El ID del consorcio es obligatorio.");
                return _consorcioDAL.ObtenerPorId(idConsorcio);
            }
            catch { throw; }
        }

        // CU06 - Crear consorcio
        public void Crear(ConsorcioBE consorcioBE)
        {
            try
            {
                ValidarConsorcio(consorcioBE);

                if (_consorcioDAL.ExisteNombre(consorcioBE.Nombre))
                    throw new Exception("El nombre del consorcio ya existe.");
                if(_consorcioDAL.ExisteCodigo(consorcioBE.Id_Consorcio))
                    throw new Exception("El código del consorcio ya existe.");

                _consorcioDAL.Crear(consorcioBE);
            }
            catch { throw; }
        }

        // CU06 FA2 - Editar consorcio
        public void Actualizar(ConsorcioBE consorcioBE)
        {
            try
            {
                ValidarConsorcio(consorcioBE);
                /*
                if (_consorcioDAL.ExisteNombre(consorcioBE.Nombre) == true){
                    throw new Exception("El nombre del consorcio ya existe.");

                }*/

                _consorcioDAL.Actualizar(consorcioBE);
            }
            catch { throw; }
        }

        // CU06 FA3/FA4 - Validar si se puede inactivar
        public void ValidarInactivacion(string idConsorcio)
        {
            try
            {
                if (_consorcioDAL.TieneExpensasPendientes(idConsorcio))
                    throw new Exception("No se puede inactivar: existen expensas pendientes.");
            }
            catch { throw; }
        }

        public void Eliminar (ConsorcioBE consorcioBE)
        {
            try
            {
                if(consorcioBE == null)
                {
                    throw new Exception("Error al eliminar.");
                }
            }
            catch { throw; }
        }
        private void ValidarConsorcio(ConsorcioBE c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(c.Direccion))
                throw new ArgumentException("La dirección es obligatoria.");
            if (c.CantUnidades <= 0)
                throw new ArgumentException("La cantidad de unidades debe ser mayor a cero.");
        }
    }
}
