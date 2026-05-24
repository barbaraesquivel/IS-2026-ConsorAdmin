using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50), Column("Usuario")]
        public string NombreUsuario { get; set; }

        [Required, MaxLength(255)]
        public string Contraseña { get; set; }

        public bool Bloqueado { get; set; }

        public bool Baja { get; set; }
    }
}
