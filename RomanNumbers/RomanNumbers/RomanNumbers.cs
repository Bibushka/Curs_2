using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbers
    {
        [TestMethod]
        public void GenerateRomanNumbersUnderTen()
        {
            string romanNumber = ConvertNumbers(7);
            Assert.AreEqual("Your number has passed the initial test.",romanNumber);
        }

        public string ConvertNumbers(int x)
        {
            string[] romanNumbers = { "IX", "V", "IV", "I" };
            int[] arabicNumbers = { 9, 5, 4, 1};
            string value=null;
            if (x > 9 || x == 0)
                return "Please enter a number smaller than 9.";
            return "Your number has passed the initial test.";
        }
    }
}
