using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbers
    {
       [TestMethod]
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
            for(int i=0; i<=3; i++)
                while (x>=arabicNumbers[i])
                    if (x - arabicNumbers[i] >= 0)
                        {
                        x = x - arabicNumbers[i];
                        value = value + romanNumbers[i];
                        }
            return value;
        }
    }
}
