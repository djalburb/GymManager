using GymManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<MetodosPagos> MetodosPagos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Suscripciones> Suscripciones { get; set; }
    }
}
