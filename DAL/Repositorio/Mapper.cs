using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Acceso;

namespace DAL.Repositorio
{
    public abstract class Mapper<t>
    {
        internal DAL.Acceso.Acceso acceso;
        public abstract int Insertar(t objeto);
        public abstract int Editar(t objeto);
        public abstract int Borrar(t objeto);
        public abstract List<t> Listar();

    }
}
