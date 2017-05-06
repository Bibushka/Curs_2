using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class Taxi
    {
        [TestMethod]
        public void TestMethod1()
        {
            int fare = CalculateCabFare(8, 5);
            Assert.AreEqual(6, fare);
        }

        public int CalculateCabFare(int hour, int distance)
        {
            return 0;
        }
    }
}
