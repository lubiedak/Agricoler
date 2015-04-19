using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Agricoler.mainDrawing
{
    public class Goods
    {
        public String type { get; private set; }
        protected int baseX;
        protected int baseY;
        public int quantity { get; private set; }

        public Goods(String type, int x, int y, int quantity)
        {
            this.type = type;
            this.baseX = x;
            this.baseY = y;
            this.quantity = quantity;
        }

        public virtual void Draw(Graphics g)
        {
            if(quantity > 0)
                DrawIconAndQuantity(g, this.baseX, this.baseY, this.type, this.quantity);
        }

        protected void DrawIconAndQuantity(Graphics g, int baseX, int baseY, String type, int quantity)
        {
            double ratio = Scaler.Ratio;
            int x = Convert.ToInt32(ratio * baseX);
            int y = Convert.ToInt32(ratio * baseY);

            Bitmap icon = Icons.Get(type);
            int iconW = Convert.ToInt32(ratio * icon.Width);
            int iconH = Convert.ToInt32(ratio * icon.Height);

            g.DrawImage(icon, new Rectangle(x, y, iconW, iconH));
            g.DrawString(quantity.ToString(), new Font("Arial", Convert.ToInt32(13 * ratio)),
                new SolidBrush(Color.Yellow), new PointF(x + 0.3f * iconW, y + 0.2f * iconH));
        }
    }
}
