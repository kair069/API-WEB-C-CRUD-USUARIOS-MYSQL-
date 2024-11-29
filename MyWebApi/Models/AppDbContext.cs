
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        // Define tus tablas aquí, por ejemplo:
        public DbSet<Usuario> Usuarios
        {
            get; set;

        }

        public class Usuario
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }
            public string? Correo { get; set; }
        }

    }
}
