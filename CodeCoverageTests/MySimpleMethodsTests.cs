using Boolean;
using CodeCoverage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverageTests
{
    [TestClass]
    public class MySimpleMethodsTests
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(10, MySimpleMethods.Sum(4, 6));
        }

        [TestMethod]
        public void TestXorEvenIfItIsInOtherProject()
        {
            Assert.IsTrue(BooleanOperations.Xor(true, false));
        }
    }
}
