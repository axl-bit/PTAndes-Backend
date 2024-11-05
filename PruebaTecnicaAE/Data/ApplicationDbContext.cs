using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAE.Models.Entities;

namespace PruebaTecnicaAE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carrros { get; set; }
    }
}
