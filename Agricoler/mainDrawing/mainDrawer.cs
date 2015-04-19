using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Agricoler.mainDrawing
{
    public class MainDrawer
    {
        List<Goods> goods;
        public MainDrawer()
        {
            goods = new List<Goods>(){
                new Goods("wood", 45, 415, 1),
                new Goods("wood", 310, 415, 3),
                new Goods("stone", 410, 415, 1),
                new Goods("stone", 690, 415, 2),
                new Goods("fence", 690, 530, 1),
                new Animals("reed", 480, 750, 4, "sheep", 395, 840),
                new Animals("pig", 625, 750, 3, "sheep", 715, 840),
                new Animals("cow", 395, 990, 3, "pig", 480, 1080),
                new Animals("horse", 625, 1080, 2, "sheep", 715, 990)
            };
            
        }

        public void Draw(Graphics g)
        {
            foreach (Goods good in goods)
            {
                good.Draw(g);
            }
        }

    }
}
