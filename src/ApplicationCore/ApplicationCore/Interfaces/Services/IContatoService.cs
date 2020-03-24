using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface IContatoService
    {
        Contato Adicionar(Contato contato);

        void Atualizar(Contato contato);

        IEnumerable<Contato> ObterTodos();

        Contato ObterPorId(int id);

        IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado);

        void Remover(Contato contato);
    }
}
