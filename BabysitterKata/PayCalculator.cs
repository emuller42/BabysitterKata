using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    public class PayCalculator
    {
        private const int RATE = 12;
        private const int AFTER_BEDTIME_RATE = 8;

        public int GetPay(int hours)
        {
            return RATE * hours;
        }

        public int GetAfterBedtimePay(int hours)
        {
            return AFTER_BEDTIME_RATE * hours;
        }
    }
}
