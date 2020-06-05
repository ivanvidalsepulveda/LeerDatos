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

        
            public DbSet<Curso> Curso{get;set;}
            public DbSet<Precio> Precio{get;set;}

            public DbSet<Comentarios> Comentarios{get;set;}


    }
}