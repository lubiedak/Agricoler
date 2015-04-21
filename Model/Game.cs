using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.GameBoard;
using Model.Delegates;

namespace Model
{
    public class Game
    {
        List<Field> BoardFields;
        public Game()
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            BoardFields = new List<Field>()
            {
                new CountableField(1, new FieldEvent[]{FieldEventsLibrary.TransferWood, FieldEventsLibrary.PlayerStartsNextTurn}),
                new CountableField(3, FieldEventsLibrary.TransferWood),
                new CountableField(1, FieldEventsLibrary.TransferStone),
                new CountableField(2, FieldEventsLibrary.TransferStone),
                new Field(FieldEventsLibrary.ChangeWoodToFence),
                new Field(new FieldEvent[]{FieldEventsLibrary.GetTwoFences, FieldEventsLibrary.ChangeTwoStonesToFence}),
                new Field(FieldEventsLibrary.GetReedStoneWood),
                new CountableField(1, new FieldEvent[]{FieldEventsLibrary.TransferFence, FieldEventsLibrary.ExtendPlayersField}),
                new Field(FieldEventsLibrary.BuildShed),
                new Field(new FieldEvent[]{FieldEventsLibrary.GetOneManger, FieldEventsLibrary.BuildManger}),
                new CountableField(1, FieldEventsLibrary.TransferHorseAndSheep),
                new CountableField(1, FieldEventsLibrary.TransferPigAndSheep),
                new Field(FieldEventsLibrary.UpgradeBuilding),
                new Field(FieldEventsLibrary.BuildSpecialBuilding),
                new CountableField(1, FieldEventsLibrary.TransferCowAndPig),
                new CountableField(1, FieldEventsLibrary.TransferHorseAndSheep),
                new Field(FieldEventsLibrary.BuildSpecialBuilding)
            };
        }
    }
}
