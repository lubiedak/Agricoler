using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Delegates
{
    public delegate void FieldEvent(Player p, int? count);

    public delegate void FieldEvent(Player p);

    public static class FieldEventsLibrary
    {
        private static void IsCountNull(int? count)
        {
            if (count == null)
                throw new Exception("Quantity of resource to transfer cannot be null value.");
        }

        public static void TransferWood(Player p, int? count)
        {
            IsCountNull(count);
            p.Resources.Wood += (int)count;
        }

        public static void TransferStone(Player p, int? count)
        {
            IsCountNull(count);
            p.Resources.Stone += (int)count;
        }

        public static void TransferWheat(Player p, int? count)
        {
            IsCountNull(count);
            p.Resources.Reed += (int)count;
        }

        private static void TransferPig(Player p, int count)
        {
            p.Resources.Pig += (int)count;
        }

        private static void TransferSheep(Player p, int count)
        {
            p.Resources.Sheep += (int)count;
        }

        private static void TransferCow(Player p, int count)
        {
            p.Resources.Cow += (int)count;
        }

        private static void TransferHorse(Player p, int count)
        {
            p.Resources.Horse += (int)count;
        }

        public static void TransferWheatAndSheep(Player p, int? count)
        {
            IsCountNull(count);

            if((int)count > 1)
            {
                TransferSheep(p, (int)count - 1);
            }

            TransferWheat(p, 1);
        }

        public static void TransferPigAndSheep(Player p, int? count)
        {
            IsCountNull(count);

            if ((int)count > 1)
            {
                TransferSheep(p, (int)count - 1);
            }

            TransferPig(p, 1);
        }

        public static void TransferCowAndPig(Player p, int? count)
        {
            IsCountNull(count);

            if ((int)count > 1)
            {
                TransferPig(p, (int)count - 1);
            }

            TransferCow(p, 1);
        }

        public static void TransferHorseAndSheep(Player p, int? count)
        {
            IsCountNull(count);

            if ((int)count > 1)
            {
                TransferSheep(p, (int)count - 1);
            }

            TransferHorse(p, 1);
        }

        public static void TransferFence(Player p, int? count)
        {
            IsCountNull(count);
            p.Resources.Fence += (int)count;
        }

        public static void GetTwoFences(Player p, int? count)
        {
            p.Resources.Fence += 2;
        }

        public static void GetReedStoneWood(Player p, int? count)
        {
            p.Resources.Wood += 1;
            p.Resources.Stone += 1;
            p.Resources.Reed += 1;
        }

        public static void GetOneManger(Player p, int? count)
        {
            p.Resources.Manger += 1;
        }

        public static void PlayerStartsNextTurn(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void ChangeWoodToFence(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void ChangeTwoStonesToFence(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void ExtendPlayersField(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void BuildShed(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void BuildManger(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void UpgradeBuilding(Player p, int? count)
        {
            throw new NotImplementedException();
        }

        public static void BuildSpecialBuilding(Player p, int? count)
        {
            throw new NotImplementedException();
        }
    }
}
