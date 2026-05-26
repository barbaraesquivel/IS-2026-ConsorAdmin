using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Servicio
{
    public Guid IdServicio { get; set; }

    public Guid IdProveedor { get; set; }

    public string IdConsorcio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public decimal Monto { get; set; }

    public string Estado { get; set; } = null!;

    public string? Factura { get; set; }

    public virtual Consorcio IdConsorcioNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
