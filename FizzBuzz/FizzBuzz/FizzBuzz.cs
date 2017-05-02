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
            string result = TalkWierd(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        public string TalkWierd(int number)
        {
            if (number % 5 == 0 && number % 3 ==0)
                return "FizzBuzz";
            return "Not";  
         }
    }
}
