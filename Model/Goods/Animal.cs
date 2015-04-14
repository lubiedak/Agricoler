using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Goods
{
    public enum AnimalType {Sheep, Pig, Cow, Horse};
    public class Animal
    {
        public AnimalType animalType { get; private set; }
        public Animal(AnimalType animalType)
        {
            this.animalType = animalType;
        }
    }
}
