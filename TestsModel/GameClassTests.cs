using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.GameBoard;

namespace TestsModel
{
    [TestClass]
    public class GameClassTests
    {
        static string playerRed = "TestPlayer1";
        static string playerBlue = "TestPlayer2";

        [TestMethod]
        public void ArePlayersInitializedProperly()
        {
            Game testGame = new Game(playerRed, playerBlue);

            Assert.IsTrue(testGame.PlayerRed.Name == playerRed);
            Assert.IsTrue(testGame.PlayerBlue.Name == playerBlue);
        }

        [TestMethod]
        public void WoodBeingTransferedUsingField2()
        {
            Game testGame = new Game(playerRed, playerBlue);
            //check if at the beginning of the game player red has 0 woods
            Assert.IsTrue(testGame.PlayerRed.Resources.Wood == 0);
            //proceed action Transfer Wood (field2)
            testGame.BoardFields[1].ProcessActions(testGame.PlayerRed);
            //check if after update wood quantity is equal to 3
            Assert.IsTrue(testGame.PlayerRed.Resources.Wood == 3);
        }

        [TestMethod]
        public void AreResourcesBeingRemovedOnCountableFields()
        {
            Game testGame = new Game(playerRed, playerBlue);
            //check if on new game field isn't empty
            Assert.IsTrue(!testGame.BoardFields[1].IsEmpty);
            //check if on new game resources quantity on field 2 is equal 3
            Assert.IsTrue(((CountableField)testGame.BoardFields[1]).Quantity == 3);
            
            //process action on the field 2
            testGame.BoardFields[1].ProcessActions(testGame.PlayerRed);

            //check if resources were removed from field 2 and if field 2 was flagged as empty
            Assert.IsTrue(((CountableField)testGame.BoardFields[1]).Quantity == 0);
            Assert.IsTrue(testGame.BoardFields[1].IsEmpty);
        }

        [TestMethod]
        public void SetStartingPlayer()
        {
            //start new game
            Game testGame = new Game(playerRed, playerBlue);
            //check if red player is starting the game
            Assert.IsTrue(testGame.StartingPlayer.Name == playerRed);
            //Process actions for field number 1
            testGame.BoardFields[0].ProcessActions(testGame.PlayerBlue);
            //check if starting player has changed for the blue player
            Assert.IsTrue(testGame.StartingPlayer.Name == playerBlue);
        }
    }
}
