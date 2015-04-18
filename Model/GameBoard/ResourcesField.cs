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
        public Resources _resources {get; private set;}
        
        public ResourcesField(int id, String name, Resources resources) : base(id, name)
        {
            _resources = resources;
        }

        public override void DoAction(Player player)
        {
            player.AddResources(_resources);
            _resources.UseAll();
        }

        public void Add(Resources resources)
        {
            _resources.Add(resources);
        }
    }
}
