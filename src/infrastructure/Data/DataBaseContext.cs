using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataBaseContext : DbContext
    {
        #region Propriedades

        public DbSet<Cliente> Clientes { get; set; }

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
        }

        #endregion
    }
}
