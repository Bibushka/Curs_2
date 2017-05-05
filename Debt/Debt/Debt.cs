using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
    [TestClass]
    public class Debt
    {
        [TestMethod]
        public void TestMethod1()
        {
            double totalAmountOwed = CalculateMoneyOwed(100, 1);
            Assert.AreEqual(102, totalAmountOwed);
        }

        public double CalculateMoneyOwed(int monthlyPayment, int numberOfDaysLate)
        {
            double totalAmountOwed=0;
            if (numberOfDaysLate == 0)
                return monthlyPayment;
            if (numberOfDaysLate >= 1 && numberOfDaysLate <= 10)
                totalAmountOwed = monthlyPayment + numberOfDaysLate * monthlyPayment * 0.02;
            return totalAmountOwed;
         }
    }
}
