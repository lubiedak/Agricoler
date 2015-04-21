using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public string Name { get; set; }

        public Player(string playerName)
        {
            // TODO: Complete member initialization
            this.Name = playerName;
            this.Resources = new GameResources();
        }

        public GameResources Resources { get; set; }

    }
}
