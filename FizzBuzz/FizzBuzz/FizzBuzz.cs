using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = TalkWierd(5);
            Assert.AreEqual("Buzz", result);
        }

        public string TalkWierd(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return "Not";  
         }
    }
}
