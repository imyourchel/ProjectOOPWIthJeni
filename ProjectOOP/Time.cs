using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Time
    {
        #region Fields
        private int hour;
        private int minute;
        private int second;
        #endregion Fields

        #region Constructors
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        #endregion Constructors

        #region Properties
        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }
        #endregion Properties

        #region Methods
        public void Convert()
        {
            throw new System.NotImplementedException();
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }
        #endregion Methods
    }
}