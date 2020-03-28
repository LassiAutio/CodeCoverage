using CodeCoverage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XorTests
{
    [TestClass]
    public class XorUnitTests
    {
        [TestMethod]
        public void FalseWhenBothAreTrue()
        {
            Assert.IsFalse(MySimpleMethods.Xor(true, true));
        }
    }
}
