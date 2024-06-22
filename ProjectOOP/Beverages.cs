using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Beverages : Items
    {
        #region Fields
        private bool isCold;
        private string size;
        #endregion Fields

        #region Constructors
        public Beverages(bool isCold, string size, string name, Image picture, int price) : base(name, picture, price)
        {
            this.IsCold = isCold;
            this.Size = size;
        }
        #endregion Constructors

        #region Properties
        public bool IsCold { get => isCold; set => isCold = value; }
        public string Size { get => size; set => size = value; }
        #endregion Properties

        #region Methods
        public void Display()
        {

        }
        #endregion Methods
    }
}