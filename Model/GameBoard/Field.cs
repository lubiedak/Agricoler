using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Field
    {
        public int id { get; private set; }
        public String name { get; private set; }
        public Action action { get; private set; } 

        public abstract void DoAction(Player p)
        {

        }

    }
}
