using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerDatos
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=CursoOnline;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<CursoInstructor>().HasKey(ci=>new {ci.CursoId, ci.InstructorId});
        }

        
            public DbSet<Curso> Curso{get;set;}
            public DbSet<Precio> Precio{get;set;}

            public DbSet<Comentarios> Comentarios{get;set;}

            public DbSet<Instructor> Instructor{get;set;}

            public DbSet<CursoInstructor> CursoInstructor{get;set;}

        


    }
}