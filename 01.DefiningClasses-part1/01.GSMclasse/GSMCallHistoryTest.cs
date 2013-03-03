using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        private GSM historyTest = new GSM("Model Test 1", "Manufacturer Test 1");
        Random rand = new Random();
        public GSMCallHistoryTest(uint NumberOfTest)
        {
            if (NumberOfTest > 0)
            {
                for (int index = 0; index < NumberOfTest; index++)
                {
                    Call call = new Call(DateTime.Today, DateTime.Today, 088123456, (ulong)((index + 1) * rand.Next(1, 100)));
                    historyTest.AddCallInHistory(call);

                }
                for (int index = 0; index < historyTest.CallHistory.Count; index++)
                {
                    Console.WriteLine("Call {0}:\nDate: {1}\nTime: {2}\nPhone Number: {3}\nDuration: {4}\n",
                        index + 1, historyTest.CallHistory[index].Date, historyTest.CallHistory[index].Time,
                        historyTest.CallHistory[index].DialedPhoneNumber, historyTest.CallHistory[index].Duration);
                }

                Console.WriteLine("Total price: " + historyTest.CallPrice(0.37m));

                ulong longestCallDuration = 0;
                Call longestCall = new Call(DateTime.Today, DateTime.Today, 0, 0);

                foreach (var item in historyTest.CallHistory)
                {
                    if (item.Duration >= longestCallDuration)
                    {
                        longestCall = item;
                    }
                }

                historyTest.DeletingCallFromHistory(longestCall);
                Console.WriteLine("New price: " + historyTest.CallPrice(0.37m));
                historyTest.ClearHistory();
                foreach (var item in historyTest.CallHistory)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Invalide Input!");
            }
        }
    }
}
