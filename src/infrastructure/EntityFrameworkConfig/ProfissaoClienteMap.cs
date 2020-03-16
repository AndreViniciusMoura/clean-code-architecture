using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityFrameworkConfig
{
    class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        #region Propriedades

        #endregion

        #region Construtor

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.ToTable("ProfissaoCliente");

            builder.HasKey(pc => pc.Id);

            builder.HasOne(pc => pc.Cliente)
                   .WithMany(c => c.ProfissaoClientes)
                   .HasForeignKey(c => c.ClienteId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Profissao)
                   .WithMany(c => c.ProfissaoClientes)
                   .HasForeignKey(c => c.ProfissaoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion
    }
}
