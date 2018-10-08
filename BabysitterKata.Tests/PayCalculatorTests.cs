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
        private const int BEFORE_BEDTIME_RATE = 12;
        private const int AFTER_BEDTIME_RATE = 8;
        private const int AFTER_MIDNIGHT_RATE = 16;

        [Test]
        [TestCase(1, 12)]
        [TestCase(2, 24)]
        public void GetPayBeforeBedtimeTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours, BEFORE_BEDTIME_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 8)]
        [TestCase(2, 16)]
        public void GetPayAfterBedtimeTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours, AFTER_BEDTIME_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 16)]
        [TestCase(2, 32)]
        public void GetPayAfterMidnightTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours, AFTER_MIDNIGHT_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }
    }
}
