using Microsoft.EntityFrameworkCore;
using prueba.Models;

namespace prueba.Data
{
    public class TrabajadoresContext : DbContext
    {
        public TrabajadoresContext(DbContextOptions<TrabajadoresContext> options) : base(options)
        {
        }

        public DbSet<Trabajador> Trabajadores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trabajador>().ToTable("NombreDeTuTablaEnLaBaseDeDatos");
        }
    }
}