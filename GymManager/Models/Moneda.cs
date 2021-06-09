using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Models
{
    public class Moneda
    {
        [Key]
        public int IdMoneda { get; set; }
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(3, ErrorMessage = "Máximo 3 caracteres")]
        public string Simbolo { get; set; }
        public virtual IEnumerable<Planes> Planes { get; set; }
    }
}
