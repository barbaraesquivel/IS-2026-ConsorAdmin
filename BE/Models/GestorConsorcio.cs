using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GestorConsorcio
{
    public int IdGestorConsorcio { get; set; }

    public Guid IdUsuario { get; set; }

    public string IdConsorcio { get; set; } = null!;

    public DateOnly FechaAsignacion { get; set; }

    public virtual Consorcio IdConsorcioNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
