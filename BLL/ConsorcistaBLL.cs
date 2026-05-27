using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class ConsorcistaBLL
    {
        private readonly ConsorcistaDAL consorcistaDAL = new ConsorcistaDAL();
        private readonly UsuarioBLL usuarioBLL = new UsuarioBLL();


        // Obtener todos
        public List<ConsorcistaBE> ObtenerTodos()
        {
            try
            {
                return consorcistaDAL.ObtenerTodos();
            }
            catch
            {
                throw;
            }
        }

        // Obtener por ID
        public ConsorcistaBE ObtenerPorId(Guid idConsorcista)
        {
            try
            {
                return consorcistaDAL.ObtenerPorId(idConsorcista);
            }
            catch
            {
                throw;
            }
        }

        // Alta
        public void Crear(ConsorcistaBE consorcistaBE)
        {
            try
            {
                if (consorcistaBE.Usuario == null)
                    throw new Exception("Debe asociar un usuario.");

                if (string.IsNullOrWhiteSpace(consorcistaBE.Usuario.Usuario))
                    throw new Exception("El username es obligatorio.");
                bool existe = false;
                foreach(var user in usuarioBLL.ObtenerTodos())
                {
                    if(user.Usuario == consorcistaBE.Usuario.Usuario)
                    {
                        existe = true;
                    }
                }

                if (existe==true)
                    throw new Exception("Ya existe un usuario con ese username.");

                consorcistaDAL.Crear(consorcistaBE);
            }
            catch
            {
                throw;
            }
        }

        // Modificación
        public void Actualizar(ConsorcistaBE consorcistaBE)
        {
            try
            {
                if (consorcistaBE.Usuario == null)
                    throw new Exception("Debe asociar un usuario.");

                if (string.IsNullOrWhiteSpace(consorcistaBE.Usuario.Usuario))
                    throw new Exception("El username es obligatorio.");

                bool existe = false;
                foreach (var user in usuarioBLL.ObtenerTodos())
                {
                    if (user.Usuario == consorcistaBE.Usuario.Usuario)
                    {
                        existe = true;
                    }
                }

                if (existe==true)
                    throw new Exception("Ya existe un usuario con ese username.");

                consorcistaDAL.Actualizar(consorcistaBE);
            }
            catch
            {
                throw;
            }
        }

        // Baja lógica
        public void Baja(Guid idConsorcista)
        {
            try
            {
                consorcistaDAL.Baja(idConsorcista);
            }
            catch
            {
                throw;
            }
        }
    }
}
