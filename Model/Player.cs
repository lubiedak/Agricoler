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
        public Resources resources { get; private set; }
        public List<Animal> animals { get; private set; }

        public Player()
        {
            resources = new Resources(0, 0, 0);
        }

        public void AddResources(Resources r)
        {
            resources.Add(r);
        }

        public void AddAnimals(List<Animal> animals)
        {

        }
    }
}
