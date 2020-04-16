using ApplicationCore.Entities;
using System.Linq;

namespace Infrastructure.Data
{
    public static class DbInitializer
    {
        #region Propriedades

        #endregion

        #region Contrutor

        #endregion

        #region Metodos

        public static void Initialize(DataBaseContext dataBaseContext)
        {
            if (dataBaseContext.Clientes.Any()) return;

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Carlos da Silva",
                    CPF = "27545656790"
                },

                new Cliente
                {
                    Nome = "João da Silva",
                    CPF = "67893478912"
                }
            };

            dataBaseContext.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Maria Tereza",
                    Telefone = "1156748970",
                    Email = "maria.tereza@uol.com.br",
                    Cliente = clientes[0]
                    
                },
                new Contato
                {
                    Nome = "Pamela Martins",
                    Telefone = "1345679429",
                    Email = "pamela.martins@uol.com.br",
                    Cliente = clientes[1]

                }
            };

            dataBaseContext.AddRange(contatos);

            dataBaseContext.SaveChanges();
        }

        #endregion
    }
}
