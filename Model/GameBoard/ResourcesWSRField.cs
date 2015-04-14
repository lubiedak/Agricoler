using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Goods;

namespace Model.GameBoard
{
    public class ResourcesWSRField : Field
    {
        public ResourcesWSRField(int id, String name) : base(id, name) { }
        public override void DoAction(Player player)
        {
            player.AddResources(new Resources(1, 1, 1));
            isOccupied = true;
        }
    }
}
