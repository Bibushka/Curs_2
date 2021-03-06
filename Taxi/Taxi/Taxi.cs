﻿using System;
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
            Assert.AreEqual(75, fare);
        }

        [TestMethod]
        public void TestDayChargeDistanceTwo()
        {
            int fare = CalculateTaxiFare(8, 50);
            Assert.AreEqual(400, fare);
        }

        [TestMethod]
        public void TestDayChargeDistanceThree()
        {
            int fare = CalculateTaxiFare(8, 70);
            Assert.AreEqual(420, fare);
        }

        [TestMethod]
        public void TestNightChargeDistanceOne()
        {
            int fare = CalculateTaxiFare(22, 5);
            Assert.AreEqual(35, fare);
        }

        [TestMethod]
        public void TestNightChargeDistanceTwo()
        {
            int fare = CalculateTaxiFare(22, 30);
            Assert.AreEqual(300, fare);
        }

        [TestMethod]
        public void TestNightChargeDistanceThree()
        {
            int fare = CalculateTaxiFare(22, 70);
            Assert.AreEqual(560, fare);
        }

        public int CalculateTaxiFare(int hour, int distance)
        {
            int fare = 0;
            if (hour >= 8 && hour < 21)
            {
                if (distance >= 1 && distance < 20)
                    fare = distance * 5;
                if (distance >= 20 && distance < 60)
                    fare = distance * 4 *2;
                if (distance > 60)
                    fare = distance * 3 * 2;
            }
            if (hour < 8 || hour >= 21 && hour <= 24)
            {
                if (distance >= 1 && distance < 20)
                    fare = distance * 7;
                if (distance >= 20 && distance < 60)
                    fare = distance * 5 * 2;
                if (distance > 60)
                    fare = distance * 4 * 2;
            }
            return fare;
        }
    }
}
