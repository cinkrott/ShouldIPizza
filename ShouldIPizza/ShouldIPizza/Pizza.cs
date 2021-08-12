using System;
using System.Collections.Generic;
using System.Text;

namespace ShouldIPizza
{
    public class Pizza
    {
        public int SaltSum { get; set; }
        public int SweetSum { get; set; }
        public int BiteSum { get; set; }
        public int RichSum { get; set; }
        public int UmamiSum { get; set; }
        public int SpicySum { get; set; }

        public Pizza(int saltSum, int sweetSum, int biteSum, int richSum, int umamiSum, int spicySum)
        {
            SaltSum = saltSum;
            SweetSum = sweetSum;
            BiteSum = biteSum;
            RichSum = richSum;
            UmamiSum = umamiSum;
            SpicySum = spicySum;
        }

    }
}
