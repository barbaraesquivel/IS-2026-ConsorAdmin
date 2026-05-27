using BE;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositorio
{
    public class LogBitacoraRepositorio : ILogBitacoraRepositorio
    {
        public void Registrar(LogBitacoraBE log)
        {
            using var ctx = new AppDbContext();
            var model = new LogBitacora
            {
                IdUsuario = log.Id_Usuario,
                FechaHora = log.FechaHora,
                Accion    = log.Accion,
                Modulo    = log.Modulo,
                Detalle   = log.Detalle
            };
            ctx.LogBitacoras.Add(model);
            ctx.SaveChanges();
        }

        public List<LogBitacoraBE> Buscar(FiltroBitacoraBE filtro)
        {
            using var ctx = new AppDbContext();

            var query = ctx.LogBitacoras.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro.IdUsuario) && Guid.TryParse(filtro.IdUsuario, out var idGuid))
                query = query.Where(l => l.IdUsuario == idGuid);

            if (filtro.FechaDesde.HasValue)
                query = query.Where(l => l.FechaHora >= filtro.FechaDesde.Value);

            if (filtro.FechaHasta.HasValue)
                query = query.Where(l => l.FechaHora < filtro.FechaHasta.Value.AddDays(1));

            if (!string.IsNullOrWhiteSpace(filtro.Modulo))
                query = query.Where(l => l.Modulo == filtro.Modulo);

            if (!string.IsNullOrWhiteSpace(filtro.Accion))
                query = query.Where(l => l.Accion == filtro.Accion);

            // Proyección plana con JOIN a USUARIO para obtener username,
            // evitando el ciclo LogBitacoraMapper → UsuarioMapper → LogBitacoraMapper.
            var rows = query
                .OrderByDescending(l => l.FechaHora)
                .Select(l => new
                {
                    l.IdLog,
                    l.IdUsuario,
                    l.FechaHora,
                    l.Accion,
                    l.Modulo,
                    l.Detalle,
                    Username = l.IdUsuarioNavigation.Username,
                    UserId   = l.IdUsuarioNavigation.IdUsuario
                })
                .ToList();

            return rows.Select(r => new LogBitacoraBE
            {
                Id_Log    = r.IdLog,
                Id_Usuario = r.IdUsuario,
                FechaHora = r.FechaHora,
                Accion    = r.Accion,
                Modulo    = r.Modulo,
                Detalle   = r.Detalle,
                usuarioBE = new BE.UsuarioBE { Id = r.UserId, Usuario = r.Username }
            }).ToList();
        }

        public List<string> ObtenerModulosUnicos()
        {
            using var ctx = new AppDbContext();
            return ctx.LogBitacoras
                .Select(l => l.Modulo)
                .Distinct()
                .OrderBy(m => m)
                .ToList();
        }

        public List<string> ObtenerAccionesUnicas()
        {
            using var ctx = new AppDbContext();
            return ctx.LogBitacoras
                .Select(l => l.Accion)
                .Distinct()
                .OrderBy(a => a)
                .ToList();
        }

        public List<(string IdUsuario, string Username)> ObtenerUsuariosConLogs()
        {
            using var ctx = new AppDbContext();
            return ctx.LogBitacoras
                .Select(l => new { IdU = l.IdUsuario.ToString(), User = l.IdUsuarioNavigation.Username })
                .Distinct()
                .OrderBy(x => x.User)
                .ToList()
                .Select(x => (x.IdU, x.User))
                .ToList();
        }
    }
}
