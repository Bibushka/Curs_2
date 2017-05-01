using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mellons
{
    [TestClass]
    public class Melons
    {
        [TestMethod]
        public string TestMethod1()
        {
            string rYes = "DA", rNo = "NU";
            int result = IsRequestDoable(5);
            if (result == 1)
               { Assert.AreEqual(1, result)
                return rYes; }
            Assert.AreEqual(0, result);
            return rNo;
        }

        public int IsRequestDoable(int x)
        {
            if ((x / 2) % 2 == 0)
                return 1;
            else
                if (((x / 2) + 1) % 2 == 0)
                    return 1;
            return 0;
            //daca x e impar, nu are rost sa se faca verificare pt ca se poate obtine doar din insumarea a unui nr par si a unuia impar
        }
    }
}
