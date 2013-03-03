using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        public GSMTest(uint NumberOfTests)
        {
            GSM[] myPhone = new GSM[NumberOfTests];
            for (int index = 0; index < myPhone.Length; index++)
            {
                myPhone[index] = new GSM("Model Test " + (index + 1), "Manufacturer Test " + (index + 1), ((index + 1) * 50), "Owner Test " + (index + 1));
                myPhone[index].Display = new Display((index + 1) * 10, (index + 1) * 55);
                myPhone[index].Battery = new Battery("Battery Test " + (index + 1), (index + 1) * 60, (index + 1) * 123);
                Console.WriteLine(myPhone[index]);
                Console.WriteLine();
            }
            GSM myIPhone = new GSM("", "");
            Console.WriteLine(myIPhone.IPhone4S);
        }
    }
}
