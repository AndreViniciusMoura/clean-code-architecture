using ApplicationCore.Entities;
using Infrastructure.EntityFrameworkConfig;
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

            modelBuilder.ApplyConfiguration(new ClienteMap());

            #endregion

            #region Contato

            modelBuilder.ApplyConfiguration(new ContatoMap());

            #endregion

            #region Profissão

            modelBuilder.ApplyConfiguration(new ProfissaoMap());

            #endregion

            #region Endereço

            modelBuilder.ApplyConfiguration(new EnderecoMap());

            #endregion

            #region Profissao Cliente

            modelBuilder.ApplyConfiguration(new ProfissaoClienteMap());

            #endregion

            #region Menu

            modelBuilder.ApplyConfiguration(new MenuMap());

            #endregion

            #endregion
        }

        #endregion
    }
}
