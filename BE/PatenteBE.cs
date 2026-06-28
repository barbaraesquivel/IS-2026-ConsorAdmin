using System.Collections.Generic;

namespace BE
{
    // Leaf: permiso simple, no tiene hijos
    public class PatenteBE : ComponentePermisoBE, IPermiso
    {
        public override void AgregarPermiso(IPermiso p) { }
        public override IList<IPermiso> ObtenerHijos => new List<IPermiso>();
        public override void QuitarPermiso(IPermiso p) { }
        public override void VaciarHijos() { }
    }
}
