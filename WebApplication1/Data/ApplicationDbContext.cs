using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Libros> Libros { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Prestamos> Prestamos { get; set; }

    }
}
