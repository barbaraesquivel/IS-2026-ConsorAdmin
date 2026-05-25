using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Usuario
{
    public Guid Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public bool Bloqueado { get; set; }

    public bool Baja { get; set; }

    public virtual Consorcistum? Consorcistum { get; set; }

    public virtual ICollection<LogBitacora> LogBitacoras { get; set; } = new List<LogBitacora>();

    public virtual Proveedor? Proveedor { get; set; }

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();
}
