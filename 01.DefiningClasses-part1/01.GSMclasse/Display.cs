using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private int? sizeColors;
        private int? numberColors;

    //task 5
        public int? SizeColors
        {
            get { return sizeColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.sizeColors = value;
                }
            }
        }
        public int? NumberColors
        {
            get { return numberColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.numberColors = value;
                }
            }
        }

   //task 2
        public Display()
        {
            this.sizeColors = null;
            this.numberColors = null;
        }
        public Display(int SizeColors)
        {
            if (SizeColors < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.sizeColors = SizeColors;
            }
            this.numberColors = null;
        }
        public Display(int SizeColors, int NumberColors)
        {
            if (SizeColors < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.sizeColors = SizeColors;
            }
            if (NumberColors < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.numberColors = NumberColors;
            }
        }

    }
}
