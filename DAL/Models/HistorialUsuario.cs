using System;

namespace DAL.Models;

public partial class HistorialUsuario
{
    public int IdHistorial { get; set; }
    public Guid IdUsuarioAuditado { get; set; }
    public Guid IdUsuarioActor { get; set; }
    public DateTime FechaCambio { get; set; }
    public string Accion { get; set; } = null!;
    public string UsernameSnap { get; set; } = null!;
    public bool ActivoSnap { get; set; }
    public bool BloqueadoSnap { get; set; }
    public string? PermisosSnap { get; set; }

    // Navegación EF
    public virtual Usuario UsuarioAuditadoNavigation { get; set; } = null!;
    public virtual Usuario UsuarioActorNavigation { get; set; } = null!;
}
