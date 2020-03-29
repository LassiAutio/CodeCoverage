using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBoolean;

namespace XorTests
{
    [TestClass]
    public class BooleanOperationsTests
    {
        [TestMethod]
        public void Xor_BothAreTrue_ReturnsFalse()
        {
            Assert.IsFalse(MyBooleanOperations.Xor(true, true));
        }
    }
}
