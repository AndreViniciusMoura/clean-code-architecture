using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataBaseContext : DbContext
    {
        #region Propriedades

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        #endregion

        #region Construtor

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        #endregion

        #region Metodos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Configurações

            #region Cliente

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            #endregion

            #region Contato

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                .HasColumnType("varchar(15)");

            #endregion

            #endregion
        }

        #endregion
    }
}
