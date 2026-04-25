using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRAC
{
    public interface IEntidad
    {
        public Guid Id { get; set; }
        public bool baja {  get; set; }
    }
}
