using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Proveedor
{
    public Guid IdProveedor { get; set; }

    public Guid IdUsuario { get; set; }

    public string Cuit { get; set; } = null!;

    public string Rubro { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
