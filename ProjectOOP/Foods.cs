using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Foods : Items
    {
        #region Fields
        private List<Ingredients> listOfIngredients;
        #endregion Fields

        #region Constructors
        public Foods(List<Ingredients> listOfIngredients, string name, Image picture, int price) : base(name, picture, price)
        {
            this.ListOfIngredients = listOfIngredients;
        }
        #endregion Constructors

        #region Properties
        public List<Ingredients> ListOfIngredients { get => listOfIngredients; set => listOfIngredients = value; }
        #endregion Properties

        #region Methods
        public void Display()
        {
            
        }

        public void AddingIngredients(string name, Image picture)
        {
            Ingredients ingredient = new Ingredients(name, picture);
            listOfIngredients.Add(ingredient);
        }
        #endregion Methods
    }
}