using CodingAgility.AnaPal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleSumTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AnaPalTests
    {
        [TestMethod]
        public void AnaPal_Test01()
        {
            AnaPal ap = new AnaPal("dooernedeevrvn");

            Assert.AreEqual(ap.IsAnagramOfPalindrome, 1);
        }

        [TestMethod]
        public void AnaPal_Test02()
        {
            AnaPal ap = new AnaPal("ssriirbtubu");

            Assert.AreEqual(ap.IsAnagramOfPalindrome, 1);
        }

        [TestMethod]
        public void AnaPal_Test03()
        {
            AnaPal ap = new AnaPal("ryan");

            Assert.AreEqual(ap.IsAnagramOfPalindrome, 0);
        }

        [TestMethod]
        public void AnaPal_Test04()
        {
            AnaPal ap = new AnaPal("onioill");

            Assert.AreEqual(ap.IsAnagramOfPalindrome, 1);
        }
    }
}
