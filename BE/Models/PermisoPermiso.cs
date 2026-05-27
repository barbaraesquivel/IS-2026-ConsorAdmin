namespace DAL.Models;

public partial class PermisoPermiso
{
    public int IdPadre { get; set; }
    public int IdHijo { get; set; }

    public virtual Permiso IdPadreNavigation { get; set; } = null!;
    public virtual Permiso IdHijoNavigation { get; set; } = null!;
}
