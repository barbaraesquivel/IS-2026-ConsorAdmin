using BE;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositorio
{
    public class HistorialUsuarioRepositorio
    {
        // Guarda un snapshot (lo llama BLL antes de cada Registrar/Modificar/Inactivar)
        public void GuardarSnapshot(
            Guid idUsuarioAuditado,
            Guid idUsuarioActor,
            string accion,
            string usernameSnap,
            bool activoSnap,
            bool bloqueadoSnap,
            string permisosSnap,
            string? emailGuardado,
            string? telefonoGuardado)
        {
            using var ctx = new AppDbContext();
            ctx.HistorialUsuarios.Add(new HistorialUsuario
            {
                IdUsuarioAuditado = idUsuarioAuditado,
                IdUsuarioActor    = idUsuarioActor,
                FechaCambio       = DateTime.Now,
                Accion            = accion,
                UsernameSnap      = usernameSnap,
                ActivoSnap        = activoSnap,
                BloqueadoSnap     = bloqueadoSnap,
                PermisosSnap      = permisosSnap,
                EmailGuardado     = emailGuardado,
                TelefonoGuardado  = telefonoGuardado
            });
            ctx.SaveChanges();
        }

        public UsuarioMemento ObtenerPorId(int idHistorial)
        {
            using var ctx = new AppDbContext();
            var h = ctx.HistorialUsuarios.Find(idHistorial);
            if (h == null) return null;
            return new UsuarioMemento(
                h.IdHistorial, h.IdUsuarioAuditado, h.IdUsuarioActor,
                h.FechaCambio, h.Accion, h.UsernameSnap, h.ActivoSnap,
                h.BloqueadoSnap, h.PermisosSnap, h.EmailGuardado, h.TelefonoGuardado);
        }

        // Devuelve todos los snapshots de un usuario ordenados del más reciente al más antiguo
        public List<UsuarioMemento> ObtenerHistorial(Guid idUsuarioAuditado)
        {
            using var ctx = new AppDbContext();
            return ctx.HistorialUsuarios
                .Where(h => h.IdUsuarioAuditado == idUsuarioAuditado)
                .OrderByDescending(h => h.FechaCambio)
                .Select(h => new UsuarioMemento(
                    h.IdHistorial,
                    h.IdUsuarioAuditado,
                    h.IdUsuarioActor,
                    h.FechaCambio,
                    h.Accion,
                    h.UsernameSnap,
                    h.ActivoSnap,
                    h.BloqueadoSnap,
                    h.PermisosSnap,
                    h.EmailGuardado,
                    h.TelefonoGuardado))
                .ToList();
        }
    }
}
