using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LogBitacora
{
    public int IdLog { get; set; }

    public Guid IdUsuario { get; set; }

    public DateTime FechaHora { get; set; }

    public string Accion { get; set; } = null!;

    public string Modulo { get; set; } = null!;

    public string? Detalle { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
