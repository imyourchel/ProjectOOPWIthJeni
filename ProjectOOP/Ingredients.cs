﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Ingredients
    {
        #region Fields
        private string name;
        private Image picture;
        #endregion Fields

        #region Constructors
        public Ingredients(string name, Image picture)
        {
            this.Name = name;
            this.Picture = picture;
        }
        #endregion Constructors

        #region Properties
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion Properties

        #region Methods
        public void Display()
        {

        }
        #endregion Methods
    }
}