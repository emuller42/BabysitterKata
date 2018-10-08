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
    }
}
