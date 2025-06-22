using Microsoft.EntityFrameworkCore;
using GestorPersonasEF.Models;

namespace GestorPersonasEF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ACER-NITRO5\\SQLEXPRESS;Database=PersonasDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
