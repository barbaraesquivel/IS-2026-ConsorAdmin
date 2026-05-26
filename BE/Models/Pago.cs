using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Pago
{
    public Guid IdPago { get; set; }

    public Guid IdExpensa { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Monto { get; set; }

    public string MedioPago { get; set; } = null!;

    public string? NroComprobante { get; set; }

    public virtual Expensa IdExpensaNavigation { get; set; } = null!;
}
