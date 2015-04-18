using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Goods;
using Model;

namespace Model.GameBoard
{
    public class ResourcesField : Field
    {
        public Resources resources {get; private set;}
        public Resources baseFill { get; private set; }
        
        public ResourcesField(int id, String name, Resources baseFill) : base(id, name)
        {
            this.baseFill = baseFill;
            Refill();
        }

        public override void DoAction(Player player)
        {
            player.AddResources(resources);
            resources.UseAll();
        }

        public override void Refill()
        {
            resources.Add(baseFill);
        }
    }
}
