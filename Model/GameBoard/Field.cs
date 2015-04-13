using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GameBoard
{
    public class Field
    {
        public int id { get; private set; }
        public String name { get; private set; }

        public Field(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual void DoAction(Player p)
        {

        }
    }
}
