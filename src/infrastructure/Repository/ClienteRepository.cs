using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using System;
using System.Linq;

namespace Infrastructure.Repository
{
    public class ClienteRepository : EFBaseRepository<Cliente>, IClienteRepository
    {
        #region Propriedades

        #endregion

        #region Construtor

        public ClienteRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Metodos

        public Cliente ObterPorProfissao(int ClienteId)
        {
            return Buscar(c => c.ProfissaoClientes.Any(p => p.ClienteId == ClienteId)).FirstOrDefault();
        }

        #endregion
    }
}
