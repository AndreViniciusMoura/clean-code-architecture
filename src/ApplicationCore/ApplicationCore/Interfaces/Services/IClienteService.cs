using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente cliente);

        void Atualizar(Cliente cliente);

        IEnumerable<Cliente> ObterTodos();

        Cliente ObterPorId(int id);

        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);

        void Remover(Cliente cliente);
    }
}
