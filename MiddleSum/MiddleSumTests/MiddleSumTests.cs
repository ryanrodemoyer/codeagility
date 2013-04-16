using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingAgility.MiddleSum;

namespace MiddleSumTests
{
    /// <summary>
    /// Run several lists to test the method MiddleSum.HasMiddleSum.
    /// </summary>
    [TestClass]
    public class MiddleSumTests
    {
        [TestMethod]
        public void MiddleSumTest_9Numbers_NotEqual()
        {
            MiddleSum ms = new MiddleSum(new int[] { 15, -2, -3, 1, 7, 8, 0, 4, 3 });

            Assert.AreEqual(ms.HasMiddleSum, false);
        }

        [TestMethod]
        public void MiddleSumTest_3Numbers_Equal()
        {
            MiddleSum ms = new MiddleSum(new int[] { 3, -1, 2 });

            Assert.AreEqual(ms.HasMiddleSum, true);
        }

        [TestMethod]
        public void MiddleSumTest_7Numbers_Equal()
        {
            MiddleSum ms = new MiddleSum(new int[] { 10, 15, -5, -7, 0, 12, -25 });

            Assert.AreEqual(ms.HasMiddleSum, true);
        }

        [TestMethod]
        public void MiddleSumTest_2Numbers_Equal()
        {
            MiddleSum ms = new MiddleSum(new int[] { -1, 1 });

            Assert.AreEqual(ms.HasMiddleSum, true);
        }

        [TestMethod]
        public void MiddleSumTest_4Numbers_NotEqual()
        {
            MiddleSum ms = new MiddleSum(new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(ms.HasMiddleSum, false);
        }

        [TestMethod]
        public void MiddleSumTest_4Numbers_Equal()
        {
            MiddleSum ms = new MiddleSum(new int[] { -5, 0, 5, 0});

            Assert.AreEqual(ms.HasMiddleSum, true);
        }
    }
}
