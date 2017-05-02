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
            string romanNumber = ConvertNumbers(9);
            Assert.AreEqual("IX",romanNumber);
        }

        public string ConvertNumbers(int x)
        {
            string romanNumbers[] = { "IX", "VIII", "V", "IV", "I" };
            int[] arabicNumbers = { 9, 8, 5, 4, 1};
            string value=null;
            for (int i = 0; i <= 4; i++)
            {
                if (x - arabicNumbers[i] == 0)
                    return romanNumbers[i];
                if (x - arabicNumbers[i] > 0)
                {
                    value = value + romanNumbers[i];
                    x = x - arabicNumbers[i];
                }
            }
            return value;
        }
    }
}
