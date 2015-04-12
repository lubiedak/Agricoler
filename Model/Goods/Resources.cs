using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Goods
{
    public class Resources
    {
        public int _wood { get; private set; }
        public int _stone { get; private set; }
        public int _reed { get; private set; }

        public Resources()
        {
            _wood  = 0;
            _stone = 0;
            _reed  = 0;
        }

        public Resources(int wood, int stone, int reed)
        {
            _wood  = wood;
            _stone = stone;
            _reed  = reed;
        }

        public Resources(Resources r)
        {
            _wood  = r._wood;
            _stone = r._stone;
            _reed  = r._reed;
        }

        public void Add(int wood, int stone, int reed)
        {
            _wood  += wood;
            _stone += stone;
            _reed  += reed;
        }
        
        public void Add(Resources r)
        {
            _wood  += r._wood;
            _stone += r._stone;
            _reed  += r._reed;
        }

        public bool isEnough(int wood, int stone, int reed)
        {
            return _wood >= wood && _stone >= stone && _reed >= reed;
        }

        public bool isEnough(Resources r)
        {
            return _wood >= r._wood && _stone >= r._stone && _reed >= r._reed;
        }

        public void Use(int wood, int stone, int reed)
        {
            if (isEnough(wood, stone, reed))
            {
                _wood  -= wood;
                _stone -= stone;
                _reed  -= reed;
            }
        }

        public void Use(Resources r)
        {
            if (isEnough(r))
            {
                _wood  -= r._wood;
                _stone -= r._stone;
                _reed  -= r._reed;
            }
        }

        public void UseAll()
        {
            _wood  = 0;
            _stone = 0;
            _reed  = 0;
        }
    }
}
