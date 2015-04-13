using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Goods;

namespace Model
{
    public class Player
    {
        public Resources _resources { get; private set; }

        public Player()
        {
            _resources = new Resources(0, 0, 0);
        }

        public void AddResources(Resources r)
        {
            _resources.Add(r);
        }
    }
}
