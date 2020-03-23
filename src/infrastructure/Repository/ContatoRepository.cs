using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ContatoRepository : EFBaseRepository<Contato>, IContatoRepository
    {
        #region Propriedades

        #endregion

        #region Construtor

        public ContatoRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Metodos

        #endregion
    }
}
