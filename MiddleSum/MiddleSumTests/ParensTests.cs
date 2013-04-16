using CodingAgility.Parens;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleSumTests
{
    /// <summary>
    /// Run several scenarios to the class Parens to check the string for a balanced list.
    /// </summary>
    [TestClass]
    public class ParensTests
    {
        [TestMethod]
        public void Parens_Test01()
        {
            Parens p = new Parens("((()))");

            Assert.AreEqual(p.IsBalanced, 1);
        }

        [TestMethod]
        public void Parens_Test02()
        {
            Parens p = new Parens("((())))");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test03()
        {
            Parens p = new Parens("(((()))())");

            Assert.AreEqual(p.IsBalanced, 1);
        }

        [TestMethod]
        public void Parens_Test04()
        {
            Parens p = new Parens("()");

            Assert.AreEqual(p.IsBalanced, 1);
        }

        [TestMethod]
        public void Parens_Test05()
        {
            Parens p = new Parens(")");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test06()
        {
            Parens p = new Parens("(");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test07()
        {
            Parens p = new Parens("( ((()())(())()() )");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test08()
        {
            Parens p = new Parens("(((()())(())()()))");

            Assert.AreEqual(p.IsBalanced, 1);
        }

        [TestMethod]
        public void Parens_Test09()
        {
            Parens p = new Parens("())");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test10()
        {
            Parens p = new Parens(")");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test11()
        {
            Parens p = new Parens("((");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test12()
        {
            Parens p = new Parens("(()))");

            Assert.AreEqual(p.IsBalanced, 0);
        }

        [TestMethod]
        public void Parens_Test13()
        {
            Parens p = new Parens("");

            Assert.AreEqual(p.IsBalanced, 1);
        }
    }
}
