using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmingLand
{
    [TestClass]
    public class FarmingLand
    {
        [TestMethod]
        public void GenerateLandLength()
        {
            double landLength = GetInitialLandSurface(770000, 230);
            Assert.AreEqual(770, landLength);
        }

        public double GetInitialLandSurface(int totalSurface, int secondSurfaceWidth)
        {
            double x = (Math.Sqrt(Math.Pow(secondSurfaceWidth,2) + 4 * totalSurface) - secondSurfaceWidth) / 2;
            return x;
        }
    }
}
