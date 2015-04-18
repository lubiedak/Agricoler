using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model2.GameBoard;
using Model2.Delegates;

namespace Model2
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
                new Field(new FieldEvent[]{(m,n)=>{m.Resources.Fence += 2; n=null;}, FieldEventsLibrary.ChangeTwoStonesToFence}),
                new Field((m,n)=>{m.Resources.Wood+=1;m.Resources.Stone+=1;m.Resources.Reed+=1;n=null;}),
                new CountableField(1, new FieldEvent[]{FieldEventsLibrary.TransferFence, FieldEventsLibrary.ExtendPlayersField}),
                new Field(FieldEventsLibrary.BuildShed),
                new Field(new FieldEvent[]{(m,n)=>{m.Resources.Manger += 1; n=null;}, FieldEventsLibrary.BuildManger}),
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
