using BE;
using DAL.Models;
using DAL.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConsorcistaDAL
    {
        // Obtener todos
        public List<ConsorcistaBE> ObtenerTodos()
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.Consorcista
                    .Include(c => c.UnidadConsorcista)
                        .ThenInclude(uc => uc.IdUnidadNavigation)
                    .Select(c => ConsorcistaMapper.Map(c))
                    .ToList();
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
                using var ctx = new AppDbContext();

                var model = ctx.Consorcista
                    .Include(c => c.UnidadConsorcista)
                        .ThenInclude(uc => uc.IdUnidadNavigation)
                    .FirstOrDefault(c => c.IdConsorcista == idConsorcista);

                if (model == null)
                    throw new Exception("Consorcista no encontrado.");

                return ConsorcistaMapper.Map(model);
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
                using var ctx = new AppDbContext();

                var model = ConsorcistaMapper.Map(consorcistaBE);

                ctx.Consorcista.Add(model);

                ctx.SaveChanges();
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
                using var ctx = new AppDbContext();

                var model = ctx.Consorcista
                    .Include(c => c.IdUsuarioNavigation)
                    .FirstOrDefault(c => c.IdConsorcista == consorcistaBE.Id_Consorcista);

                if (model == null)
                    throw new Exception("Consorcista no encontrado.");

                // DATOS DE USUARIO
                model.IdUsuarioNavigation.Username = consorcistaBE.Usuario.Usuario;

                ctx.SaveChanges();
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
                using var ctx = new AppDbContext();

                var model = ctx.Consorcista
                    .Include(c => c.IdUsuarioNavigation)
                    .FirstOrDefault(c => c.IdConsorcista == idConsorcista);

                if (model == null)
                    throw new Exception("Consorcista no encontrado.");

                model.IdUsuarioNavigation.Bloqueado = true;

                ctx.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // Validar DNI duplicado
        public bool ExisteDNI(string dni, Guid? idExcluir = null)
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.Consorcista.Any(c =>
                    c.Dni == dni &&
                    (!idExcluir.HasValue || c.IdConsorcista != idExcluir.Value));
            }
            catch
            {
                throw;
            }
        }
    }
}
