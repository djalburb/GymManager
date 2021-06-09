using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManager.Models
{
    public class Planes
    {
        [Key]
        public int IdPlan { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La descripcion debe tener de 2 a 100 caracteres")]
        [Display(Name = "Descripción 1")]
        public string Descripcion1 { get; set; }
        [StringLength(100)]
        [Display(Name = "Descripción 2")]
        public string Descripcion2 { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El codigo debe tener de 3 a 20 caracteres")]
        [Display(Name = "Código Alterno")]
        public string CodigoAlterno { get; set; }
        [Display(Name = "Duración Días")]
        public int DuracionDias { get; set; }
        [Required(ErrorMessage = "Favor ingresar precio")]
        [Range(0.0, Double.MaxValue)]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Favor ingresar precio")]
        [Range(0.0, Double.MaxValue)]
        public double Descuento { get; set; }

        //Relacion Con Monedas
        [Display(Name = "Moneda")]
        public int IdMoneda { get; set; }

        [ForeignKey("IdMoneda")]
        public virtual Moneda Moneda { get; set; }
    }
}