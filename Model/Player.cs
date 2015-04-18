using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Goods;
using Model.GameBoard;

namespace Model
{
    public class Player
    {
        public string Name { get; set; }

        public Resources resources { get; private set; }
        public List<Animal> animals { get; private set; }

        public Player()
        {
            resources = new Resources(0, 0, 0);
        }

        public Player(string name)
        {
            Name = name;
            resources = new Resources(0, 0, 0);
        }

        public void AddResources(Resources r)
        {
            resources.Add(r);
        }

        public bool HasEnoughResources(Resources r)
        {
            return resources.Compare(r);
        }

        public void AddAnimals(List<Animal> animals)
        {

        }

        public void BuyBuilding(List<Building> buildings)
        {

        }
    }
}
