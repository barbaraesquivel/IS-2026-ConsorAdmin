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
    public class ConsorcioDAL
    {
        // CU06 - Listar consorcios asignados a un gestor
        public List<ConsorcioBE> ObtenerPorGestor(Guid idUsuario)
        {
            try
            {
                using var ctx = new AppDbContext();
                var lista = ctx.GestorConsorcios
                     .Include(gc => gc.IdConsorcioNavigation)
                         .ThenInclude(c => c.Unidads)
                     .Include(gc => gc.IdConsorcioNavigation)
                         .ThenInclude(c => c.Servicios)
                     .Include(gc => gc.IdConsorcioNavigation)
                         .ThenInclude(c => c.GestorConsorcios)
                     .Where(gc => gc.IdUsuario == idUsuario)
                     .Select(gc => gc.IdConsorcioNavigation)
                     .ToList();
                return lista
                    .Select(c => ConsorcioMapper.Map(c))
                    .ToList();
                /*
                return ctx.GestorConsorcios
                    .Where(gc => gc.IdUsuario == idUsuario)
                    .Select(gc => gc.IdConsorcioNavigation)
                    .Include(c => c.Unidads)
                    .Include(c => c.Servicios)
                    .Include(c => c.GestorConsorcios)
                    .Select(c => ConsorcioMapper.Map(c))
                    .ToList();*/
            }
            catch { throw; }
        }

        // CU06 - Listar todos los consorcios (para admin)
        public List<ConsorcioBE> ObtenerTodos()
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Consorcios
                    .Include(c => c.Unidads)
                    .Include(c => c.Servicios)
                    .Include(c => c.GestorConsorcios)
                        .ThenInclude(gc => gc.IdUsuarioNavigation)
                    .Select(c => ConsorcioMapper.Map(c))
                    .ToList();
            }
            catch { throw; }
        }

        // CU06 - Obtener por ID
        public ConsorcioBE ObtenerPorId(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Consorcios
                    .Include(c => c.Unidads)
                    .Include(c => c.Servicios)
                    .Include(c => c.GestorConsorcios)
                        .ThenInclude(gc => gc.IdUsuarioNavigation)
                    .FirstOrDefault(c => c.IdConsorcio == idConsorcio);
                return ConsorcioMapper.Map(model);
            }
            catch { throw; }
        }

        // CU06 - Crear consorcio
        public void Crear(ConsorcioBE consorcioBE)
        {
            try
            {
                using (var ctx = new AppDbContext())
                {
                    var model = ConsorcioMapper.Map(consorcioBE);
                    ctx.Consorcios.Add(model);
                    ctx.SaveChanges();
                }

            }
            catch { throw; }
        }

        // CU06 - Editar consorcio
        public void Actualizar(ConsorcioBE consorcioBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Consorcios.FirstOrDefault(c => c.IdConsorcio == consorcioBE.Id_Consorcio);
                if (model == null) throw new Exception("Consorcio no encontrado.");

                model.Nombre = consorcioBE.Nombre;
                model.Direccion = consorcioBE.Direccion;
                model.CantUnidades = consorcioBE.CantUnidades;
                ctx.SaveChanges();
            }
            catch { throw; }
        }

        // CU06 - Verificar nombre duplicado
        public bool ExisteNombre(string nombre)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Consorcios.Any(c =>
                    c.Nombre == nombre);
            }
            catch { throw; }
        }
        public bool ExisteCodigo(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Consorcios.Any(c =>
                    c.IdConsorcio == idConsorcio);
            }
            catch { throw; }
        }

        // CU06 FA3/FA4 - Verificar si tiene expensas pendientes
        public bool TieneExpensasPendientes(string idConsorcio)
        {
            try
            {
                using var ctx = new AppDbContext();
                return ctx.Expensas.Any(e =>
                    e.IdUnidadNavigation.IdConsorcio == idConsorcio &&
                    (e.Estado == "Pendiente" || e.Estado == "Vencida"));
            }
            catch { throw; }
        }
        public void Eliminar(ConsorcioBE consorcioBE)
        {
            try
            {
                using var ctx = new AppDbContext();
                var model = ctx.Consorcios.FirstOrDefault(c => c.IdConsorcio == consorcioBE.Id_Consorcio);
                if (model == null) throw new Exception("Consorcio no encontrado.");
                ctx.Consorcios.Remove(model);
                ctx.SaveChanges();
            }
            catch { throw; }
        }
    }
}

