using BE.Models;
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
    public int? IdIdiomaPreferido { get; set; }
    public string? Email { get; set; }
    public string? Telefono { get; set; }
    public Idioma IdiomaPreferidoNavigation { get; set; }
    public virtual Consorcistum? Consorcistum { get; set; }
    public virtual ICollection<GestorConsorcio> GestorConsorcios { get; set; } = new List<GestorConsorcio>();

    public virtual ICollection<LogBitacora> LogBitacoras { get; set; } = new List<LogBitacora>();

    public virtual Proveedor? Proveedor { get; set; }

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();
}
