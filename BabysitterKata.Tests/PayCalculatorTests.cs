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

        private PayCalculator payCalculator;

        [SetUp]
        public void SetUp()
        {
            payCalculator = new PayCalculator();
        }

        [Test]
        [TestCase(1, 12)]
        [TestCase(2, 24)]
        public void GetPayBeforeBedtimeTest(int hours, int expectedPay)
        {
            int actualPay = payCalculator.GetPay(hours, BEFORE_BEDTIME_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 8)]
        [TestCase(2, 16)]
        public void GetPayAfterBedtimeTest(int hours, int expectedPay)
        {
            int actualPay = payCalculator.GetPay(hours, AFTER_BEDTIME_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        [TestCase(1, 16)]
        [TestCase(2, 32)]
        public void GetPayAfterMidnightTest(int hours, int expectedPay)
        {
            int actualPay = payCalculator.GetPay(hours, AFTER_MIDNIGHT_RATE);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        public void GetHoursBeforeBedtimeOneHourTest()
        {
            const int expectedHours = 1;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 23, 0, 0);
            DateTime bedTime = new DateTime(2011, 11, 11, 18, 0, 0);
            int actualHours = payCalculator.GetHoursBeforeBedtime(startTime, endTime, bedTime);
            Assert.AreEqual(expectedHours, actualHours);
        }

        [Test]
        public void GetHoursBeforeBedtimeFractionalHourTest()
        {
            const int expectedHours = 1;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 23, 0, 0);
            DateTime bedTime = new DateTime(2011, 11, 11, 17, 1, 0);
            int actualHours = payCalculator.GetHoursBeforeBedtime(startTime, endTime, bedTime);
            Assert.AreEqual(expectedHours, actualHours);
        }

        [Test]
        public void GetHoursBeforeBedtimeTwoHoursTest()
        {
            const int expectedHours = 2;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 23, 0, 0);
            DateTime bedTime = new DateTime(2011, 11, 11, 19, 0, 0);
            int actualHours = payCalculator.GetHoursBeforeBedtime(startTime, endTime, bedTime);
            Assert.AreEqual(expectedHours, actualHours);
        }

        [Test]
        public void GetHoursBeforeBedtimeThreeAndAFractionalHourTest()
        {
            const int expectedHours = 4;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 23, 0, 0);
            DateTime bedTime = new DateTime(2011, 11, 11, 20, 45, 0);
            int actualHours = payCalculator.GetHoursBeforeBedtime(startTime, endTime, bedTime);
            Assert.AreEqual(expectedHours, actualHours);
        }

        [Test]
        public void GetTotalPayBeforeBedtimeTest()
        {
            const int expectedPay = 12;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 18, 0, 0);
            int actualPay = payCalculator.GetTotalPayBeforeBedtime(startTime, endTime);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        public void GetTotalPayBeforeBedtimeFractionalTest()
        {
            const int expectedPay = 36;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 19, 30, 0);
            int actualPay = payCalculator.GetTotalPayBeforeBedtime(startTime, endTime);
            Assert.AreEqual(expectedPay, actualPay);
        }

        [Test]
        public void GetHoursBeforeBedtimeEnhancedTest()
        {
            const int expectedHours = 1;
            DateTime startTime = new DateTime(2011, 11, 11, 17, 0, 0);
            DateTime endTime = new DateTime(2011, 11, 11, 19, 0, 0);
            DateTime bedTime = new DateTime(2011, 11, 11, 18, 0, 0);
            int actualHours = payCalculator.GetHoursBeforeBedtime(startTime, endTime, bedTime);
            Assert.AreEqual(expectedHours, actualHours);
        }
    }
}
