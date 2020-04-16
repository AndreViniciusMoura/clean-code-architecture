namespace ApplicationCore.Entities
{
    public class Contato
    {
        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public Cliente Cliente { get; set; }

        #region Foreign Key

        public int ClienteId { get; set; }

        #endregion

        #endregion

        #region Construtor

        public Contato()
        {

        }

        #endregion

        #region Metodos

        #endregion
    }
}
