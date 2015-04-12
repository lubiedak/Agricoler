using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsModel
{
    [TestClass]
    public class TestField
    {
        [TestMethod]
        public void ThisIsAlwaysTrue()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ThisIsNotTrue()
        {
            Assert.IsTrue(false);
        }
    }
}
