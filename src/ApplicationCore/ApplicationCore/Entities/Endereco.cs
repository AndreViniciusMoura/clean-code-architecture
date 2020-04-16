using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Endereco
    {
        #region Propriedades

        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Referencia { get; set; }

        public Cliente Cliente { get; set; }

        #region Foreign Key

        public int ClienteId { get; set; }

        #endregion

        #endregion

        #region Construtor

        public Endereco()
        {

        }    

        #endregion

        #region Metodos

        #endregion
    }
}
