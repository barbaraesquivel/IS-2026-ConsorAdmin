using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Expensa
{
    public Guid IdExpensa { get; set; }

    public int IdUnidad { get; set; }

    public string Periodo { get; set; } = null!;

    public decimal Monto { get; set; }

    public DateOnly Vencimiento { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
