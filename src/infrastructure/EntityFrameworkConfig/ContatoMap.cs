using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityFrameworkConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        #region Propriedades

        #endregion

        #region Construtor  

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(c => c.Email)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.Telefone)
                   .HasColumnType("varchar(15)");

            builder.HasOne(c => c.Cliente)
                   .WithMany(c => c.Contatos)
                   .HasForeignKey(c => c.ClienteId)
                   .HasPrincipalKey(c => c.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion
    }
}
