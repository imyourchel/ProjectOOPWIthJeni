using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Customers
    {
        #region Fields
        private string name;
        private Image picture;
        private string type;
        private Items orderItem;
        #endregion Fields

        #region Constructors
        public Customers(string name, Image picture, string type, Items orderItem)
        {
            this.Name = name;
            this.Picture = picture;
            this.Type = type;
            this.OrderItem = orderItem;
        }
        #endregion Constructors

        #region Properties
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public string Type { get => type; set => type = value; }
        public Items OrderItem { get => orderItem; set => orderItem = value; }
        #endregion Properties

        #region Methods
        public void Display()
        {

        }
        #endregion Methods
    }
}