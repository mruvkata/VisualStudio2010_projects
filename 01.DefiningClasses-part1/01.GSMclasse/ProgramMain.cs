using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class Programmain
    {
        public static void Main()
        {
            Battery newBatery = new Battery("Japod",6000,35);            
            Call newCall = new Call(DateTime.Now ,new DateTime(),1,1);

            GSM myGSM = new GSM("5800", "Nokia");

            myGSM.Display = new Display(4443, 123321);

            Console.WriteLine(myGSM);
       
       /*   GSMTest gsmTest1 = new GSMTest(5);

            Console.WriteLine(myGSM);


            Console.WriteLine(newBatery);
            Console.WriteLine(newCall);
            */  
        }
    }
}
