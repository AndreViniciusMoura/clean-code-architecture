using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Cliente
    {
        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public Endereco Endereco { get; set; }

        public ICollection<ProfissaoCliente> ProfissaoClientes { get; set; }

        #endregion

        #region Construtor

        public Cliente()
        {
            Contatos = new List<Contato>();
            ProfissaoClientes = new List<ProfissaoCliente>();
        }

        #endregion

        #region Metodos

        #endregion
    }
}
