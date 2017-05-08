using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class Taxi
    {
        [TestMethod]
        public void TestDayChargeDistanceOne()
        {
            int fare = CalculateTaxiFare(8, 15);
            Assert.AreEqual(105, fare);
        }

        [TestMethod]
        public void TestDayChargeDistanceTwo()
        {
            int fare = CalculateTaxiFare(8, 50);
            Assert.AreEqual(500, fare);
        }

        [TestMethod]
        public void TestDayChargeDistanceThree()
        {
            int fare = CalculateTaxiFare(8, 70);
            Assert.AreEqual(420, fare);
        }

        [TestMethod]
        public void TestNightCharge()
        {
            int fare = CalculateTaxiFare(22, 5);
            Assert.AreEqual(35, fare);
        }


        public int CalculateTaxiFare(int hour, int distance)
        {
            int fare = 0;
            if (hour >= 8 && hour < 21)
            {
                if (distance >= 1 && distance < 20)
                    fare = distance * 7;
                if (distance >= 20 && distance < 60)
                    fare = distance * 5 *2;
                if (distance > 60)
                    fare = distance * 3 * 2;
            }
            if (hour < 8 || hour >= 21 && hour<=24)
                fare = distance * 7;
            return fare;
        }
    }
}
