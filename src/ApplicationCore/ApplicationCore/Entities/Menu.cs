using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Menu
    {
        #region Propriedades

        public int Id { get; set; }

        public string Titulo { get; set; }

        public ICollection<Menu> SubMenu { get; set; }

        #region Foreign Key

        public int? MenuId { get; set; }

        #endregion

        #endregion

        #region Contrutor

        public Menu()
        {
            SubMenu = new List<Menu>();
        }

        #endregion

        #region Metodos

        #endregion
    }
}
