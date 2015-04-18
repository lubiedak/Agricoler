using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GameBoard
{
    public class ActionField : Field
    {
        

        public ActionField(int id, String name) : base(id,name)
        {

        }

        public Action action { get; private set; }
    }
}
