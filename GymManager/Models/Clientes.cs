using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManager.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Nombre debe contener de 3 a 100 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El Nombre debe contener de 3 a 150 caracteres")]
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Dirección de correo no válida")]
        public string Correo { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        //Relacion con tabla Ciudades
        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }

        [ForeignKey("IdCiudad")]
        public virtual Ciudades Ciudades { get; set; }
        public virtual IEnumerable<Suscripciones> Subcripciones { get; set; }

        public string FullName { get { return IdCliente + " - " + Nombre + " " + Apellidos; } }

    }
}
