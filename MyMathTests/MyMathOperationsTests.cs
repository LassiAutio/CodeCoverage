using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MyMathTests
{
    [TestClass]
    public class MyMathOperationsTests
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(10, MyMathOperations.Sum(4, 6));
        }
    }
}
