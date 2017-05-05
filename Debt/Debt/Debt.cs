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
            double totalAmountOwed = CalculateMoneyOwed(100, 0);
            Assert.AreEqual(100, totalAmountOwed);
        }

        public double CalculateMoneyOwed(int monthlyPayment, int numberOfDaysLate)
        {
            double totalAmountOwed=0;
            if (numberOfDaysLate == 0)
                return monthlyPayment;
            
            return totalAmountOwed;
         }
    }
}
