using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityFrameworkConfig
{
    class MenuMap : IEntityTypeConfiguration<Menu>
    {
        #region Propriedades

        #endregion

        #region Construtor

        #endregion

        #region Metodos

        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");

            builder.HasKey(m => m.Id);

            builder.HasMany(m => m.SubMenu)
                   .WithOne()
                   .HasForeignKey(m => m.MenuId);

        }

        #endregion
    }
}
