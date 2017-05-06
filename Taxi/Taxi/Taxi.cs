using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class Taxi
    {
        [TestMethod]
        public void GetDayPrice()
        {
            int fare = CalculateCabFare(8, 5);
            Assert.AreEqual(25, fare);
        }

        [TestMethod]
        public int GetNightPrice()
        {
            int fare = CalculateCabFare(22, 16);
            Assert.AreEqual(112, fare);
        }

        public int CalculateCabFare(int hour, int distance)
        {
            int fare;
            if (hour >= 8 && hour < 21)
                return fare = distance * 5;
            if (hour >= 21 && hour < 8)
                return fare = distance * 7;
            return 0;
        }
    }
}
