using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UsuarioPermiso
{
    public string IdUsuarioPermiso { get; set; }

    public Guid IdUsuario { get; set; }

    public Guid IdPermiso { get; set; }

    public virtual Permiso IdPermisoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
