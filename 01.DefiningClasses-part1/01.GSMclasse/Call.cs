using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        private DateTime date;
        private DateTime time;
        private uint dialedPhoneNumber;
        private ulong duration;

        public Call(DateTime Date, DateTime Time, uint DialedPhoneNumber, ulong Duration)
        {
            this.date = Date;
            this.time = Time;
            this.dialedPhoneNumber = DialedPhoneNumber;
            this.duration = Duration;
        }

        public DateTime Date
        {
            get { return this.date; }
        }
        public DateTime Time
        {
            get { return this.time; }
        }
        public uint DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
        }
        public ulong Duration
        {
            get { return this.duration; }
        }
    }
}
