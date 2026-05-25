using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Consorcistum
{
    public Guid IdConsorcista { get; set; }

    public Guid IdUsuario { get; set; }

    public string Dni { get; set; } = null!;

    public string? Telefono { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<UnidadConsorcistum> UnidadConsorcista { get; set; } = new List<UnidadConsorcistum>();
}
