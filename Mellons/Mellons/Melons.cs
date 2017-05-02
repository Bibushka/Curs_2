using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mellons
{
    [TestClass]
    public class Melons
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = IsRequestDoable(14);
            Assert.AreEqual("DA", result);
        }

        public string IsRequestDoable(double x)
        {
            if ((x / 2) % 2 == 0)
                return "DA";
            else
                if (((x / 2) + 1) % 2 == 0)
                return "DA";
            return "NU";
            //daca x e impar, nu are rost sa se faca verificare pt ca se poate obtine doar din insumarea a unui nr par si a unuia impar
        }
    }
}
