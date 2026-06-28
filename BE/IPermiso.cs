using System.Collections.Generic;

namespace BE
{
    // Component: interfaz común para hojas y compuestos del patrón Composite
    public interface IPermiso
    {
        int Id_Permiso { get; set; }
        string Nombre { get; set; }
        void AgregarPermiso(IPermiso p);
        void QuitarPermiso(IPermiso p);
        void VaciarHijos();
        IList<IPermiso> ObtenerHijos { get; }
    }
}
