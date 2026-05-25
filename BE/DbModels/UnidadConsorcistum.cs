using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UnidadConsorcistum
{
    public string IdUnidadConsorcista { get; set; }

    public string IdUnidad { get; set; }

    public string IdConsorcista { get; set; }

    public string TipoVinculo { get; set; } = null!;

    public virtual Consorcistum IdConsorcistaNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
