using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class ProfissaoCliente
    {
        #region Propriedades

        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public Profissao Profissao { get; set; }

        #region Foreign Key        

        public int ClienteId { get; set; }

        public int ProfissaoId { get; set; }

        #endregion

        #endregion

        #region Construtor

        public ProfissaoCliente()
        {

        }

        #endregion

        #region Metodos

        #endregion
    }
}
