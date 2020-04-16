using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    class ProfissaoRepository : EFBaseRepository<Profissao>, IProfissaoRepository
    {
        #region Propriedades

        #endregion

        #region Construtor

        public ProfissaoRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Metodos

        #endregion
    }
}
