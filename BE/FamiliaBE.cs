using System.Collections.Generic;
using System.Linq;

namespace BE
{
    public class FamiliaBE : ComponentePermisoBE
    {
        public List<ComponentePermisoBE> Hijos { get; set; } = new();

        public override void Agregar(ComponentePermisoBE hijo) => Hijos.Add(hijo);
        public override void Quitar(ComponentePermisoBE hijo) => Hijos.Remove(hijo);
        public override List<ComponentePermisoBE> ObtenerHijos() => Hijos;

        public override bool Contiene(int idPermiso)
        {
            if (Id_Permiso == idPermiso) return true;
            return Hijos.Any(h => h.Contiene(idPermiso));
        }
    }
}
