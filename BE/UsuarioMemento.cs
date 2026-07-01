using System;

namespace BE
{
    // MEMENTO — encapsula el snapshot del estado del usuario en un momento dado.
    // Solo expone getters; el estado interno no puede modificarse desde afuera.
    public class UsuarioMemento
    {
        public int IdHistorial { get; }           // PK de la tabla HISTORIAL_USUARIO
        public Guid IdUsuarioAuditado { get; }
        public Guid IdUsuarioActor { get; }
        public DateTime FechaCambio { get; }
        public string Accion { get; }             // 'ALTA' | 'MODIFICACION' | 'BAJA'
        public string UsernameSnap { get; }
        public bool ActivoSnap { get; }
        public bool BloqueadoSnap { get; }
        public string PermisosSnap { get; }       // "1,3,7" o null

        public UsuarioMemento(
            int idHistorial,
            Guid idUsuarioAuditado,
            Guid idUsuarioActor,
            DateTime fechaCambio,
            string accion,
            string usernameSnap,
            bool activoSnap,
            bool bloqueadoSnap,
            string permisosSnap)
        {
            IdHistorial       = idHistorial;
            IdUsuarioAuditado = idUsuarioAuditado;
            IdUsuarioActor    = idUsuarioActor;
            FechaCambio       = fechaCambio;
            Accion            = accion;
            UsernameSnap      = usernameSnap;
            ActivoSnap        = activoSnap;
            BloqueadoSnap     = bloqueadoSnap;
            PermisosSnap      = permisosSnap;
        }

        // Descripción legible para mostrar en el DataGridView / combo
        public string Descripcion =>
            $"{FechaCambio:dd/MM/yyyy HH:mm:ss} | {Accion} | Usuario: {UsernameSnap} | Activo: {ActivoSnap} | Bloqueado: {BloqueadoSnap}";
    }
}
