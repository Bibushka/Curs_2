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
            double totalAmountOwed = CalculateMoneyOwed(100, 32);
            Assert.AreEqual(520, totalAmountOwed);
        }

        public double CalculateMoneyOwed(int monthlyPayment, int numberOfDaysLate)
        {
            double totalAmountOwed=0;
            if (numberOfDaysLate == 0)
                return monthlyPayment;
            if (numberOfDaysLate >= 1 && numberOfDaysLate <= 10)
                totalAmountOwed = monthlyPayment + numberOfDaysLate * monthlyPayment * 0.02;
            if (numberOfDaysLate >= 11 && numberOfDaysLate <= 30)
                totalAmountOwed = monthlyPayment + numberOfDaysLate * monthlyPayment * 0.05;
            if (numberOfDaysLate >= 31 && numberOfDaysLate <= 40)
                totalAmountOwed = 2*monthlyPayment + numberOfDaysLate * monthlyPayment * 0.10;
            return totalAmountOwed;
         }
    }
}
