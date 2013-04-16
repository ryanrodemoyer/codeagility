using CodingAgility.BitRev;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleSumTests
{
    /// <summary>
    /// Summary description for BetRevTests
    /// </summary>
    [TestClass]
    public class BetRevTests
    {
        [TestMethod]
        public void TestMethod_01()
        {
            Assert.AreEqual(BitRev.BitReverse(25), 19);
        }

        [TestMethod]
        public void TestMethod_02()
        {
            Assert.AreEqual(BitRev.BitReverse(26), 11);
        }

        [TestMethod]
        public void TestMethod_03()
        {
            Assert.AreEqual(BitRev.BitReverse(11), 13);
        }

        [TestMethod]
        public void TestMethod_05()
        {
            Assert.AreEqual(BitRev.SymmetricBinaryRoot(286), 22);
        }

        [TestMethod]
        public void TestMethod_04()
        {
            Assert.AreEqual(BitRev.SymmetricBinaryRoot(3245), 55);
        }
    }
}
