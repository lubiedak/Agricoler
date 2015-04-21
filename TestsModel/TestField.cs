using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.GameBoard;
using Model;

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

        /*
        [TestMethod]
        public void GetAnimalsFromField()
        {
            AnimalField field = new AnimalField();
        }*/
    }
}
