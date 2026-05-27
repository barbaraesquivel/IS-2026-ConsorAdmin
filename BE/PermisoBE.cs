using System.Collections.Generic;

namespace BE
{
    public class PermisoBE : ComponentePermisoBE
    {
        public List<UsuarioPermisoBE> usuarioPermisos { get; set; } = new();
        public override void AgregarPermiso(IPermiso p) { }
        public override IList<IPermiso> ObtenerHijos => new List<IPermiso>();
        public override void QuitarPermiso(IPermiso p) { }
        public override void VaciarHijos() { }
    }
}
