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
        public void GetPayTest()
        {
            const int expectedPay = 12;
            PayCalculator payCalculator = new PayCalculator();
            int actualPay = payCalculator.GetPay();
            Assert.AreEqual(expectedPay, actualPay);
        }
    }
}
