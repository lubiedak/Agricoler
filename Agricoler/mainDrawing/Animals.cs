using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Agricoler.mainDrawing
{
    class Animals : Goods
    {
        int baseX2;
        int baseY2;
        String type2;

        public Animals(String type, int x, int y, int quantity, String type2, int x2, int y2)
            : base(type, x, y, quantity)
        {
            this.type2 = type2;
            this.baseX2 = x2;
            this.baseY2 = y2;
        }

        public override void Draw(Graphics g)
        {
            if (quantity > 0)
                DrawIconAndQuantity(g, baseX, baseY, type, 1);
            if (quantity > 1)
                DrawIconAndQuantity(g, baseX2, baseY2, type2, quantity - 1);

        }
    }
}
