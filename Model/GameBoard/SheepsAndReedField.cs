using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Goods;
using Model;

namespace Model.GameBoard
{
    public class SheepsAndReedField : Field
    {
        private int reed;
        List<Animal> sheeps;

        public SheepsAndReedField(int id, String name)
            : base(id, name)
        {
            reed = 1;
            sheeps = new List<Animal>();
        }

        public override void DoAction(Player player)
        {
            player.AddAnimals(sheeps);
            player.AddResources(new Resources(0, 0, reed));
            sheeps.Clear();
            reed = 0;
            isOccupied = true;
        }

        public override void Refill()
        {
            if(reed == 0)
                reed++;
            else
                sheeps.Add(new Animal(AnimalType.Sheep));
            isOccupied = false;
        }
    }
}
