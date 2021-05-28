using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Models
{
    public class MetodosPagos
    {
        [Key]
        public int IdMetodoPago { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, ErrorMessage = "El nombre no debe tener mas de 100 caracteres")]
        public string Nombre { get; set; }
    }
}
