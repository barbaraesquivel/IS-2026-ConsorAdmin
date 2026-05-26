using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Usuario
{
    public Guid IdUsuario { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string TipoUsuario { get; set; } = null!;

    public bool Bloqueado { get; set; }

    public bool Activo { get; set; }

    public virtual Consorcistum? Consorcistum { get; set; }

    public virtual ICollection<LogBitacora> LogBitacoras { get; set; } = new List<LogBitacora>();

    public virtual Proveedor? Proveedor { get; set; }

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();
}
