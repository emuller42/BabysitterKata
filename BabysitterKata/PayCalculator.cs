using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    public class PayCalculator
    {
        private const int BEFORE_BEDTIME_RATE = 12;
        private const int AFTER_BEDTIME_RATE = 8;
        private const int AFTER_MIDNIGHT_RATE = 16;

        public int GetPay(int hours, int rate)
        {
            return hours * rate;
        }

        public int GetHoursBeforeBedtime(DateTime startTime, DateTime endTime)
        {
            int returnHours = 0;
            TimeSpan timeWorked = endTime - startTime;
            returnHours = timeWorked.Hours;
            if (timeWorked.Minutes > 0)
            {
                returnHours += 1;
            }
            return returnHours;
        }
    }
}
