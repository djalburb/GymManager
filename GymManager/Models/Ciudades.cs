using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Models
{
    public class Ciudades
    {
        [Key]
        public int IdCiudad { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "La ciudad debe tener de 3 a 100 caracteres")]
        public string Nombre { get; set; }
        public virtual IEnumerable<Clientes> Clientes { get; set; }
    }
}
