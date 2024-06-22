using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Players
    {
        #region Fields
        private string name;
        private int income;
        private Image picture;
        private Time completedTime;
        #endregion Fields

        #region Constructors
        public Players(string name, int income, Image picture, Time completedTime)
        {
            this.Name = name;
            this.Income = income;
            this.Picture = picture;
            this.CompletedTime = completedTime;
        }
        #endregion Constructors

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Income { get => income; set => income = value; }
        public Image Picture { get => picture; set => picture = value; }
        public Time CompletedTime { get => completedTime; set => completedTime = value; }
        #endregion Properties

        #region Methods
        public void Display()
        {
            throw new System.NotImplementedException();
        }
        #endregion Methods
    }
}