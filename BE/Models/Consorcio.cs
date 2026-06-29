using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Consorcio
{
    public string IdConsorcio { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CantUnidades { get; set; }

    public int? Dvh { get; set; }

    public virtual ICollection<GestorConsorcio> GestorConsorcios { get; set; } = new List<GestorConsorcio>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();
}
