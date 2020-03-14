using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataBaseContext : DbContext
    {
        #region Propriedades

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Profissao> Profissoes { get; set; }

        public DbSet<ProfissaoCliente> ProfissaoClientes { get; set; }

        public DbSet<Menu> Menus { get; set; }

        #endregion

        #region Construtor

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        #endregion

        #region Metodos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configurações

            #region Cliente

            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Cliente>().Property(c => c.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.Id);

            #endregion

            #region Contato

            modelBuilder.Entity<Contato>().ToTable("Contato");

            modelBuilder.Entity<Contato>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Contato>().Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Telefone)
                .HasColumnType("varchar(15)");

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.Id);

            #endregion

            #region Profissão

            modelBuilder.Entity<Profissao>().ToTable("Profissao");

            modelBuilder.Entity<Profissao>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Profissao>().Property(p => p.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.CBO)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            #endregion

            #region Endereço

            modelBuilder.Entity<Endereco>().ToTable("Endereco");

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Referencia)
                .HasColumnType("varchar(400)");

            #endregion

            #region Profissao Cliente

            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(pc => pc.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.ProfissaoClientes)
                .HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Profissao)
                .WithMany(c => c.ProfissaoClientes)
                .HasForeignKey(c => c.ProfissaoId);

            #endregion

            #region Menu

            modelBuilder.Entity<Menu>().ToTable("Menu");

            modelBuilder.Entity<Menu>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Menu>()
                .HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            #endregion

            #endregion
        }

        #endregion
    }
}
