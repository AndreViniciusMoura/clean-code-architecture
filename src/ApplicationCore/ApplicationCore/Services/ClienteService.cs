using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        #region Propriedades

        private readonly IClienteRepository _clienteRepository;

        #endregion

        #region Contrutor

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        #endregion

        #region Metodos

        public Cliente Adicionar(Cliente cliente)
        {
            return _clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            //TODO: Regras de negócio para adicionar um cliente

            _clienteRepository.Atualizar(cliente);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente cliente)
        {
            _clienteRepository.Remover(cliente);
        }

        #endregion
    }
}
