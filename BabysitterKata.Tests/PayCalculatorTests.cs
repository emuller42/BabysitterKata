using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata.Tests
{
    [TestFixture]
    public class PayCalculatorTests
    {
        [Test]
        public void GetPayTestForOneHourTest()
        {
            const int hours = 1;
            const int expectedPay = 12;
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        public void GetPayForTwoHoursTest()
        {
            const int hours = 2;
            const int expectedPay = 24;
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours);
            Assert.AreEqual(expectedPay, actualPay);
        }
    }
}
