using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManager.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int Edad { get; set; }
        // Relacion con Ciudades
        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }

        [ForeignKey("IdCiudad")]
        public virtual Ciudades Ciudades { get; set; }
    }
}