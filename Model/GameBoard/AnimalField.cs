using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Goods;
using Model;


namespace Model.GameBoard
{
    public class AnimalField : Field
    {
        public List<Animal> animals { get; private set; }
        AnimalType firstType;
        AnimalType restType;

        public AnimalField(int id, String name, AnimalType first, AnimalType rest)
            : base(id, name)
        {
            this.animals = new List<Animal>();
            this.firstType = first;
            this.restType = rest;
        }

        public override void DoAction(Player player)
        {
            player.AddAnimals(animals);
            animals.Clear();
        }

        public override void Refill()
        {
            if (animals.Count() == 0)
                animals.Add(new Animal(firstType));
            else
                animals.Add(new Animal(restType));
        }
    }
}
