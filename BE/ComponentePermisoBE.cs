using System.Collections.Generic;

namespace BE
{
    public abstract class ComponentePermisoBE
    {
        public int Id_Permiso { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public virtual void Agregar(ComponentePermisoBE hijo)
        {
            throw new System.NotSupportedException("Este permiso no permite agregar hijos");
        } 
        public virtual void Quitar(ComponentePermisoBE hijo)
          {
            throw new System.NotSupportedException("Este permiso no permite quitar hijos");
        } 
        public virtual List<ComponentePermisoBE> ObtenerHijos()
        {
            return new List<ComponentePermisoBE>();
        } 
        public virtual bool Contiene(int idPermiso)
        {
            return Id_Permiso == idPermiso;
        } 
    }
}
