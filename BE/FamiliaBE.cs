using System;
using System.Collections.Generic;
using System.Linq;

namespace BE
{
    // Composite: puede contener otros IPermiso (familias y patentes)
    public class FamiliaBE : ComponentePermisoBE, IPermiso
    {
        private IList<IPermiso> _hijos;
        public FamiliaBE() { _hijos = new List<IPermiso>(); }

        public override void AgregarPermiso(IPermiso p)
        {
            if (_hijos.Any(h => h.Id_Permiso == p.Id_Permiso))
                throw new Exception("Este elemento ya es hijo directo de esta familia.");
            _hijos.Add(p);
        }

        public override IList<IPermiso> ObtenerHijos => _hijos.ToArray();

        public override void QuitarPermiso(IPermiso p)
        {
            if (this.TieneHijo(p)) _hijos.Remove(p);
        }

        public override void VaciarHijos() => _hijos = new List<IPermiso>();

        public bool TieneHijo(IPermiso hijo)
        {
            if (this.Id_Permiso == hijo.Id_Permiso) return true;
            if (this.ObtenerHijos.Count > 0)
            {
                foreach (IPermiso p in this.ObtenerHijos)
                {
                    if (p.Id_Permiso == hijo.Id_Permiso) return true;
                    if (p.ObtenerHijos.Count > 0)
                        if (((FamiliaBE)p).TieneHijo(hijo)) return true;
                }
            }
            return false;
        }
    }
}
