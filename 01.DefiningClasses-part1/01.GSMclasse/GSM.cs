using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     
namespace MobilePhone
{
    class GSM
    {

    //task 6
        static GSM IPhone4s = new GSM("4S", "Apple");


        public Display Display = new Display();
        public Battery Battery = new Battery();
        private static List<Call> callHistory = new List<Call>();

   //task 1
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;     

   //task 5  Properties
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal? Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get { return owner; }
            set { this.owner = value; }
        }

        public GSM IPhone4S
        {
            get { return IPhone4s; }
        }
        public List<Call> CallHistory
        {
            get { return callHistory; }
        }
   
   //task 2  Constructors
        public GSM(string Model,string Manufacturer)
        {
            this.Model = Model;
            this.manufacturer = Manufacturer;
            this.price = null;
            this.owner = null;
        }
        public GSM(string Model, string Manufacturer, int Price)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = Price;
            }
            this.owner = null;
        }
        public GSM(string Model, string Manufacturer, int Price, string Owner)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = Price;
            }
            this.owner = Owner;
        }
     
   // methods
        public void AddCallInHistory(Call call)
        {
            callHistory.Add(call);
        }
        public bool DeletingCallFromHistory(Call call)
        {
            for (int i = 0; i < callHistory.Count ;i++)
            {
                if (callHistory[i].Date == call.Date &&
                    callHistory[i].Time == call.Time &&
                    callHistory[i].DialedPhoneNumber == call.DialedPhoneNumber &&
                    callHistory[i].Duration == call.Duration)
                {
                    callHistory.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }
        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal sum = 0;
            foreach (var item in callHistory)
            {
                sum += (decimal)item.Duration;
            }
            return sum*pricePerMinute;
        }

     //task 4
        public override string ToString()
        {
            string outPut = "";
            outPut += "GSM Model: " + model;
            outPut += "\nGSM Manufacturer: " + manufacturer;
     
            if (price != null)
            {
                outPut += "\nGSM Price: " + price;
            }
            else
            {
                outPut += "\nGSM Price: no information";
            }
     
            if (owner != null)
            {
                outPut += "\nGSM Owner: " + owner;
            }
            else
            {
                outPut += "\nGSM Owner: no information";
            }
     
            if (Display.NumberColors != null)
            {
                outPut += "\nGSM Display Number of Colors: " + Display.NumberColors;
            }
            else
            {
                outPut += "\nGSM Display Number of Colors: no information";
            }
     
            if (Display.SizeColors != null)
            {
                outPut += "\nGSM Display Size of Colors: " + Display.SizeColors;
            }
            else
            {
                outPut += "\nGSM Display Size of Colors: no information";
            }
     
            if (Battery.HoursIdle != null)
            {
                outPut += "\nGSM Battery Hours Idle: " + Battery.HoursIdle;
            }
            else
            {
                outPut += "\nGSM Battery Hours Idle: no information";
            }
     
            if (Battery.HoursTalk != null)
            {
                outPut += "\nGSM Battery Hours Talk: " + Battery.HoursTalk;
            }
            else
            {
                outPut += "\nGSM Battery Hours Talk: no information";
            }
     
            if (Battery.Model != null)
            {
                outPut += "\nGSM Battery Model: " + Battery.Model;
            }
            else
            {
                outPut += "\nGSM Battery Model: no information";
            }
     
            return outPut;
        }
    }
}