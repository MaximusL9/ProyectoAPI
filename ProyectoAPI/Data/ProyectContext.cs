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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Employees>().HasData(Employees);
        }
    }
}
