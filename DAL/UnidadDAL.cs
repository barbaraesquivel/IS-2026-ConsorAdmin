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
    public class UnidadDAL
    {
        // CU07 - Listar unidades de un consorcio
        public List<UnidadBE> ObtenerPorConsorcio(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Unidads
                    .Where(u => u.IdConsorcio == idConsorcio)
                    .Include(u => u.Expensas)
                    .Include(u => u.UnidadConsorcista)
                        .ThenInclude(uc => uc.IdConsorcistaNavigation)
                    .Select(u => UnidadMapper.Map(u))
                    .ToList();
            }
            catch { throw; }
        }

        // CU07 - Obtener por ID
        public UnidadBE ObtenerPorId(int idUnidad)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Unidads
                    .Include(u => u.Expensas)
                    .Include(u => u.UnidadConsorcista)
                    .Include(u => u.IdConsorcioNavigation)
                    .FirstOrDefault(u => u.IdUnidad == idUnidad);
                return UnidadMapper.Map(model);
            }
            catch { throw; }
        }

        // CU07 - Crear unidad; retorna el ID asignado por la base de datos
        public int Crear(UnidadBE unidadBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = UnidadMapper.Map(unidadBE);
                ctx.Unidads.Add(model);
                ctx.SaveChanges();
                return model.IdUnidad;
            }
            catch { throw; }
        }

        public int ContarPorConsorcio(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Unidads.Count(u => u.IdConsorcio == idConsorcio);
            }
            catch { throw; }
        }

        // CU07 FA2 - Editar unidad
        public void Actualizar(UnidadBE unidadBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Unidads.FirstOrDefault(u => u.IdUnidad == unidadBE.Id_Unidad);
                if (model == null) throw new Exception("Unidad no encontrada.");

                model.IdConsorcio = unidadBE.Id_Consorcio;
                model.Piso = unidadBE.Piso;
                model.Depto = unidadBE.Depto;
                model.Superficie = unidadBE.Superficie;
                ctx.SaveChanges();
            }
            catch { throw; }
        }
        // CU07 FA2 - Eliminar unidad
        public void Eliminar(UnidadBE unidadBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Unidads.FirstOrDefault(u => u.IdUnidad == unidadBE.Id_Unidad);
                if (model == null) throw new Exception("Unidad no encontrada.");

                ctx.Unidads.Remove(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }
        // CU07 FA1 - Verificar piso+depto duplicado en el mismo consorcio
        public bool ExistePisoDepto(string idConsorcio, string piso, string depto, int idUnidadExcluir = 0)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Unidads.Any(u =>
                    u.IdConsorcio == idConsorcio &&
                    u.Piso == piso &&
                    u.Depto == depto &&
                    u.IdUnidad != idUnidadExcluir);
            }
            catch { throw; }
        }

        // CU07 FA3 - Verificar expensas pendientes en la unidad
        public bool TieneExpensasPendientes(int idUnidad)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Expensas.Any(e =>
                    e.IdUnidad == idUnidad &&
                    (e.Estado == "Pendiente" || e.Estado == "Vencida"));
            }
            catch { throw; }
        }

        public List<UnidadBE> ObtenerTodas()
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.Unidads
                    .Include(u => u.IdConsorcioNavigation)
                    .Include(u => u.UnidadConsorcista)
                        .ThenInclude(uc => uc.IdConsorcistaNavigation)
                            .ThenInclude(c => c.IdUsuarioNavigation)
                    .Select(u => UnidadMapper.Map(u))
                    .ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
