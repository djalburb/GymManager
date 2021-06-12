using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManager.Models
{
    public class Suscripciones
    {
        [Key]
        public int IdSuscripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        [Display(Name = "Método de Pago")]
        public int IdMetodoPago { get; set; }
        [Required]
        [Display(Name = "Plan")]
        public int IdPlan { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        [Range(0, Int32.MaxValue)]
        public int Cantidad { get; set; }
        [Display(Name = "Precio Unitario")]
        public double PrecioUnit { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Clientes Clientes { get; set; }
        [ForeignKey("IdMetodoPago")]
        public virtual MetodosPagos MetodosPagos { get; set; }
        [ForeignKey("IdPlan")]
        public virtual Planes Planes { get; set; }
    }
}
