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
        [TestCase(1, 12)]
        [TestCase(2, 24)]
        public void GetPayTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay(hours);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 8)]
        [TestCase(2, 16)]
        public void GetAfterBedtimePayTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetAfterBedtimePay(hours);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 16)]
        public void GetAfterMidnightPayTest(int hours, int expectedPay)
        {
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetAfterMidnightPay(hours);
            Assert.AreEqual(expectedPay, actualPay);
        }
    }
}
