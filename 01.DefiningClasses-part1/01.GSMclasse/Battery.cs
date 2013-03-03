using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Battery
    {
        public enum BatteryType
        {
            Li_Ion, NiMH, NiCd
        }

        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

    //task 5
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public int? HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }
        public int? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string Model)
        {
            this.model = Model;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string Model, int HoursIdle) : this(Model)
        {            
            if (HoursIdle < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.hoursIdle = HoursIdle;
            }
            this.hoursTalk = null;
        }
        public Battery(string Model, int HoursIdle, int HoursTalk) : this(Model, HoursIdle)
        {           
            if (HoursTalk < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.hoursTalk = HoursTalk;
            }
        }

        public override string ToString()
        {
            string outPut = "";
            outPut += "Battery Model: " + this.Model + "\n";
            outPut += "Hours idle: " + this.HoursIdle + "\n";
            outPut += "Hours talk: " + this.HoursTalk + "\n";
            return outPut;
        }
    }
}
