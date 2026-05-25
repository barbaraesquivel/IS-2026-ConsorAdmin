using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Unidad
{
    public string IdUnidad { get; set; }

    public string IdConsorcio { get; set; } = null!;

    public string Piso { get; set; } = null!;

    public string Depto { get; set; } = null!;

    public decimal? Superficie { get; set; }

    public virtual ICollection<Expensa> Expensas { get; set; } = new List<Expensa>();

    public virtual Consorcio IdConsorcioNavigation { get; set; } = null!;

    public virtual ICollection<UnidadConsorcistum> UnidadConsorcista { get; set; } = new List<UnidadConsorcistum>();
}
