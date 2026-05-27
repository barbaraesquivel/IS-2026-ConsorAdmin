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
    public class UnidadConsorcistaDAL
    {
        public List<Unidad_ConsorcistaBE> ObtenerPorUnidad(int idUnidad)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.UnidadConsorcista
                    .Where(uc => uc.IdUnidad == idUnidad)
                    .Include(uc => uc.IdConsorcistaNavigation)
                        .ThenInclude(c => c.IdUsuarioNavigation)
                    .Select(uc => Unidad_ConsorcistaMapper.Map(uc))
                    .ToList();
            }
            catch { throw; }
        }

        public List<ConsorcistaBE> ObtenerConsorcistasDisponibles()
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Consorcista
                    .Include(c => c.IdUsuarioNavigation)
                    .Select(c => ConsorcistaMapper.Map(c))
                    .ToList();
            }
            catch { throw; }
        }

        public bool ExisteAsociacion(int idUnidad, Guid idConsorcista)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.UnidadConsorcista.Any(uc =>
                    uc.IdUnidad == idUnidad &&
                    uc.IdConsorcista == idConsorcista);
            }
            catch { throw; }
        }

        public void Asociar(Unidad_ConsorcistaBE asociacionBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = Unidad_ConsorcistaMapper.Map(asociacionBE);
                ctx.UnidadConsorcista.Add(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }

        public void Eliminar(Unidad_ConsorcistaBE unidad_ConsorcistaBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.UnidadConsorcista.FirstOrDefault(u => u.IdUnidadConsorcista == unidad_ConsorcistaBE.Id_Unidad_Consorcista);
                if (model == null) throw new Exception("Relacion de unidad y consorcista no encontrada.");

                ctx.UnidadConsorcista.Remove(model);
                ctx.SaveChanges();
            }
            catch { throw;  }
        }
        public void QuitarAsociacion(int idUnidadConsorcista)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.UnidadConsorcista
                    .FirstOrDefault(uc => uc.IdUnidadConsorcista == idUnidadConsorcista);
                if (model == null) throw new Exception("Asociacion no encontrada.");
                ctx.UnidadConsorcista.Remove(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }
    }
}
