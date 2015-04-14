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
        protected bool isOccupied { get; set; }

        public Field(int id, String name)
        {
            this.id = id;
            this.name = name;
            isOccupied = false;
        }

        public virtual bool CanDoAction(Player p)
        {
            return !isOccupied;
        }

        public virtual void DoAction(Player p) { isOccupied = true; }

        public virtual void Refill() { isOccupied = false; }
    }
}
