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
            string romanNumber = ConvertNumbers(8);
            Assert.AreEqual("Please enter a number smaller than 9.",romanNumber);
        }

        public void GenerateRomanNumbers()
        {
            string romanNumber = ConvertNumbers(8);
            Assert.AreEqual("VIII", romanNumber);
        }

        public string ConvertNumbers(int x)
        {
            string[] romanNumbers = { "IX", "V", "IV", "I" };
            int[] arabicNumbers = { 9, 5, 4, 1};
            string value=null;
            if (x > 9 || x == 0)
                return "Please enter a number smaller than 9.";
            for(int i=0; i<=3; i++)
                while (x!=0)
                    {
                    if (x - arabicNumbers[i] == 0)
                        {
                        value = value + romanNumbers[i];
                        }
                    if (x - arabicNumbers[i] >= 0)
                        {
                        x = x - arabicNumbers[i];
                        value = value + romanNumbers[i];
                        }
                     }
            return value;
        }
    }
}
