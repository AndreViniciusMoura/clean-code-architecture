using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityFrameworkConfig
{
    class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        #region Propriedades

        #endregion

        #region Construtor

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.ToTable("Profissao");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                   .HasColumnType("varchar(400)")
                   .IsRequired();

            builder.Property(p => p.CBO)
                   .HasColumnType("varchar(400)")
                   .IsRequired();

            builder.Property(p => p.Descricao)
                   .HasColumnType("varchar(1000)")
                   .IsRequired();
        }

        #endregion
    }
}
