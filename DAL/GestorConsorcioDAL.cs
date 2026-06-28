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
    public class GestorConsorcioDAL
    {
        public List<GestorConsorcioBE> ObtenerTodos()
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.GestorConsorcios
                    .Include(u => u.IdConsorcioNavigation)
                    .Include(u => u.IdUsuarioNavigation)
                    .Select(u => GestorConsorcioMapper.Map(u))
                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<GestorConsorcioBE> ObtenerPorConsorcio(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.GestorConsorcios
                    .Where(u => u.IdConsorcio == idConsorcio)
                    .Select(u => GestorConsorcioMapper.Map(u))
                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        public void Eliminar(GestorConsorcioBE gestorConsorcioBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.GestorConsorcios.FirstOrDefault(g => g.IdGestorConsorcio == gestorConsorcioBE.Id_GestorConsorcio);
                if (model == null) throw new Exception("Gestor no encontrado.");
                ctx.GestorConsorcios.Remove(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }
        public void Crear(GestorConsorcioBE gestorConsorcioBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = GestorConsorcioMapper.Map(gestorConsorcioBE);
                ctx.GestorConsorcios.Add(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }
    }
}
