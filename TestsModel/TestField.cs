using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.GameBoard;
using Model.Goods;
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

        [TestMethod]
        public void GetResourcesFromField()
        {
            ResourcesField field = new ResourcesField(0, "Get Wood", new Resources(3, 0, 0));
            Player player = new Player();
            field.DoAction(player);

            Assert.IsTrue(field._resources.Equals( new Resources(0, 0, 0) ));
            Assert.IsFalse(field._resources.Equals( new Resources(0, 0, 1) ));

            Assert.IsTrue(player._resources.Equals( new Resources(3, 0, 0) ));
            Assert.IsFalse(player._resources.Equals( new Resources(0, 4, 0) ));

            player.AddResources(new Resources(0, 5, 5));
            Assert.IsTrue(player._resources.Equals(new Resources(3, 5, 5)));
        }
        /*
        [TestMethod]
        public void GetAnimalsFromField()
        {
            AnimalField field = new AnimalField();
        }*/
    }
}
