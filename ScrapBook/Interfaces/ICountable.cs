using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2.Interfaces
{
    public interface ICountable
    {
        public int Quantity { get; private set; }
    }
}
