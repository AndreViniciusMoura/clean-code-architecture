using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.EntityFrameworkConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        #region Propriedades

        #endregion

        #region Construtor

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CPF)
                   .HasColumnType("varchar(11)")
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.HasMany(c => c.Contatos)
                   .WithOne(c => c.Cliente)
                   .HasForeignKey(c => c.ClienteId)
                   .HasPrincipalKey(c => c.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Endereco)
                   .WithOne(c => c.Cliente)
                   .HasForeignKey<Endereco>(c => c.ClienteId);
        }

        #endregion
    }
}
