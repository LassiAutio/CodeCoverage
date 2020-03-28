using Boolean;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XorTests
{
    [TestClass]
    public class BooleanOperationsTests
    {
        [TestMethod]
        public void FalseWhenBothAreTrue()
        {
            Assert.IsFalse(BooleanOperations.Xor(true, true));
        }
    }
}
