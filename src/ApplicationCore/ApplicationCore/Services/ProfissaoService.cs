using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Services
{
    public class ProfissaoService : IProfissaoService
    {
        #region Propriedades

        private readonly IProfissaoRepository _profissaoRepository;

        #endregion

        #region Contrutor

        public ProfissaoService(IProfissaoRepository profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }

        #endregion

        #region Metodos

        public Profissao Adicionar(Profissao profissao)
        {
            return _profissaoRepository.Adicionar(profissao);
        }

        public void Atualizar(Profissao profissao)
        {
            //TODO: Regras de negócio para adicionar uma Profissao

            _profissaoRepository.Atualizar(profissao);
        }

        public IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicado)
        {
            return _profissaoRepository.Buscar(predicado);
        }

        public Profissao ObterPorId(int id)
        {
            return _profissaoRepository.ObterPorId(id);
        }

        public IEnumerable<Profissao> ObterTodos()
        {
            return _profissaoRepository.ObterTodos();
        }

        public void Remover(Profissao profissao)
        {
            _profissaoRepository.Remover(profissao);
        }

        #endregion
    }
}
