using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityFrameworkConfig
{
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        #region Propriedades

        #endregion

        #region Construtor

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Bairro)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(e => e.CEP)
                   .HasColumnType("varchar(15)")
                   .IsRequired();

            builder.Property(e => e.Logradouro)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(e => e.Referencia)
                   .HasColumnType("varchar(400)");
        }

        #endregion
    }
}
