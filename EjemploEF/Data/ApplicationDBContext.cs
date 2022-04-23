using Microsoft.EntityFrameworkCore;
using EjemploEF.Models;

namespace EjemploEF.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet <Course> Courses { get; set; }

        public DbSet<Enrrollments> Enrrollments { get; set; }

        //genera el codigo para la migracion de las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)//al momento que se ejecuta crea la tabla
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
