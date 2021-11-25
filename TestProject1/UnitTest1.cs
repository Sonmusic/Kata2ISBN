using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestISBN10()
        {
            bool isbn10 = Kata2.Program.Validate("123456789X");
            Assert.AreEqual(true, isbn10);
        }

        [TestMethod]
        public void TestISBN113()
        {
            bool isbn13 = Kata2.Program.Validate("9782123456803");
            Assert.AreEqual(true, isbn13);
        }

        [TestMethod]
        public void TestVacio()
        {
            bool vacio = Kata2.Program.Validate("");
            Assert.AreEqual(false, vacio);
        }

        [TestMethod]
        public void TestErroneo()
        {
            bool ERROR = Kata2.Program.Validate("123456789x");
            Assert.AreEqual(false, ERROR);
        }

        [TestMethod]
        public void TestErrorTamaño()
        {
            bool ERROR = Kata2.Program.Validate("978212345680");
            Assert.AreEqual(false, ERROR);
        }

    }
}
