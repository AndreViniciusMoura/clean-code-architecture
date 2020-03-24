using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        #region Propriedades

        private readonly IContatoRepository _contatoRepository;

        #endregion

        #region Contrutor

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        #endregion

        #region Metodos

        public Contato Adicionar(Contato contato)
        {
            return _contatoRepository.Adicionar(contato);
        }

        public void Atualizar(Contato contato)
        {
            //TODO: Regras de negócio para adicionar um Contato

            _contatoRepository.Atualizar(contato);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato contato)
        {
            _contatoRepository.Remover(contato);
        }

        #endregion
    }
}
