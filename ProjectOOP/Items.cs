﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Items
    {
        #region Fields
        private string name;
        private Image picture;
        private int price;
        #endregion Fields

        #region Constructors
        public Items(string name, Image picture, int price)
        {
            this.Name = name;
            this.Picture = picture;
            this.Price = price;
        }
        #endregion Constructors

        #region Properties
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Price { get => price; set => price = value; }
        #endregion Properties

        #region Methods
        public void DisplatItems()
        {

        }
        public void Display()
        {

        }
        #endregion Methods
    }
}