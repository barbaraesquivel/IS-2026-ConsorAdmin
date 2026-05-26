using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UnidadConsorcistum
{
    public int IdUnidadConsorcista { get; set; }

    public int IdUnidad { get; set; }

    public Guid IdConsorcista { get; set; }

    public string TipoVinculo { get; set; } = null!;

    public virtual Consorcistum IdConsorcistaNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
