using Microsoft.EntityFrameworkCore;
using ProyectoAPI.Models;

namespace ProyectoAPI.Data
{
    public class ProyectContext: DbContext
    {
        public ProyectContext(DbContextOptions<ProyectContext> options) : base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Employees>().HasData(Employees);
        }
    }
}
