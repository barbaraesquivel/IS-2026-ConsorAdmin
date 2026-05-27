using System.Collections.Generic;

namespace BE
{
    public abstract class ComponentePermisoBE : IPermiso
    {
        public int Id_Permiso { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public abstract void AgregarPermiso(IPermiso p);
        public abstract void QuitarPermiso(IPermiso p);
        public abstract void VaciarHijos();
        public abstract IList<IPermiso> ObtenerHijos { get; }
    }
}
