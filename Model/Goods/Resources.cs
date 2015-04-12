using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resources
    {
        int _wood;
        int _stone;
        int _reed;

        public Resources()
        {
            _wood = 0;
            _stone = 0;
            _reed = 0;
        }

        public void AddResources();
    }
}
