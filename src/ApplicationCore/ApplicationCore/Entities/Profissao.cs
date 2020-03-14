using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Profissao
    {
        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string CBO { get; set; }

        public ICollection<ProfissaoCliente> ProfissaoClientes { get; set; }

        #endregion

        #region Construtor

        public Profissao()
        {
            ProfissaoClientes = new List<ProfissaoCliente>();
        }

        #endregion

        #region Metodos

        #endregion
    }
}
