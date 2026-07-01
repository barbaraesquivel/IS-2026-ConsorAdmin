using BE;
using DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class HistorialUsuarioBLL
    {
        private readonly HistorialUsuarioRepositorio _repo = new();

        public void RegistrarSnapshot(
            Guid idUsuarioAuditado,
            Guid idUsuarioActor,
            string accion,
            string usernameSnap,
            bool activoSnap,
            bool bloqueadoSnap,
            List<int> permisosIds)
        {
            string permisosSnap = permisosIds != null && permisosIds.Count > 0
                ? string.Join(",", permisosIds)
                : null;

            _repo.GuardarSnapshot(
                idUsuarioAuditado, idUsuarioActor, accion,
                usernameSnap, activoSnap, bloqueadoSnap, permisosSnap);
        }

        public List<UsuarioMemento> ObtenerHistorial(Guid idUsuarioAuditado)
            => _repo.ObtenerHistorial(idUsuarioAuditado);
    }
}
