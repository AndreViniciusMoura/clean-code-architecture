using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface IProfissaoService
    {
        Profissao Adicionar(Profissao profissao);

        void Atualizar(Profissao profissao);

        IEnumerable<Profissao> ObterTodos();

        Profissao ObterPorId(int id);

        IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicado);

        void Remover(Profissao profissao);
    }
}
