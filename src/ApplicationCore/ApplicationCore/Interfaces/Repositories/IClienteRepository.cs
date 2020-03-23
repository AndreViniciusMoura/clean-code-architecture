using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Repositories
{
    public interface IClienteRepository: IBaseRepository<Cliente>
    {
        Cliente ObterPorProfissao(int ClienteId);
    }
}
