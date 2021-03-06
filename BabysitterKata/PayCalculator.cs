﻿using System;
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

        public int GetHoursBeforeBedtime(DateTime startTime, DateTime endTime, DateTime bedTime)
        {
            int returnHours = 0;
            TimeSpan timeWorked = bedTime - startTime;
            returnHours = timeWorked.Hours;
            if (timeWorked.Minutes > 0)
            {
                returnHours += 1;
            }
            return returnHours;
        }

        public int GetTotalPayBeforeBedtime(DateTime startTime, DateTime endTime, DateTime bedTime)
        {
            int returnPay = 0;
            int hours = GetHoursBeforeBedtime(startTime, endTime, bedTime);
            returnPay = GetPay(hours, BEFORE_BEDTIME_RATE);
            return returnPay;
        }

        public DateTime ParseHours(string hourString)
        {
            DateTime returnTime;
            int parsedHour = Int32.Parse(hourString);
            returnTime = DateTime.Today.AddHours(parsedHour);
            return returnTime;
        }

        public int GetTotalPay(string[] inputs)
        {
            int returnPay = 0;
            DateTime startTime = ParseHours(inputs[0]);
            DateTime endTime = ParseHours(inputs[1]);
            DateTime bedTime = ParseHours(inputs[2]);
            returnPay += GetTotalPayBeforeBedtime(startTime, endTime, bedTime);
            return returnPay;
        }
    }
}
