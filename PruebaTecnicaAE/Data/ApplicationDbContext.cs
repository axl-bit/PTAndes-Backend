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
        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                .HasName("pk_ClienteId");

                entity.ToTable("Cliente");

                entity.Property(e => e.ClienteId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Nombres");

                entity.Property(e => e.ClienteId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Apellidos");

                entity.Property(e => e.ClienteId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DocIdentificacion");

                entity.HasOne(e => e.CarrosDeCliente)
                .WithMany(d => d.Cliente)
                .HasForeignKey(p => p.CarroIdCliente)
                .HasConstraintName("pk CarrosIdCliente");
            });

            modelBuilder.Entity<Carro>(entity =>
            {
                entity.HasKey(e => e.CarroId)
                .HasName("pk_CarroId");

                entity.ToTable("Carro");

                entity.Property(e => e.Modelo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Modelo");

                entity.Property(e => e.Marca)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Marca");

                entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Placa");


            });

            modelBuilder.Entity<Aparcamiento>(entity =>
            {
                entity.HasKey(e => e.EspacioAId)
                .HasName("pk_EspacioAId");

                entity.ToTable("Aparcamiento");

                entity.Property(e => e.NroPlaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NroPlaca");
            });
        }
    }
}
