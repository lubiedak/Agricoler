using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Goods;

namespace Model.GameBoard
{
    class BuildingField : Field
    {
        List<Building> buildings;

        public BuildingField(int id, String name, List<Building> buildings)
            : base(id, name)
        {
            this.buildings = buildings;
        }

        public override bool CanDoAction(Player p)
        {
            return CanPayForAny(p) && !isOccupied;
        }

        public override void DoAction(Player p)
        {
            p.BuyBuilding(buildings); //should work on refference to this list
            isOccupied = true;
        }

        private bool CanPayForAny(Player p)
        {
            foreach (Building b in buildings)
            {
                if (p.HasEnoughResources(b.cost))
                    return true;
            }
            return false;
        }
    }
}
