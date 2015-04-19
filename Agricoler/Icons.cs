using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Agricoler
{
    public static class Icons
    {
        static Dictionary<String, Bitmap> icons = new Dictionary<String, Bitmap>()
        {
            {"wood", global::Agricoler.Properties.Resources.wood},
            {"stone", global::Agricoler.Properties.Resources.stone},
            {"reed", global::Agricoler.Properties.Resources.reed},
            {"sheep", global::Agricoler.Properties.Resources.sheep},
            {"pig", global::Agricoler.Properties.Resources.pig},
            {"cow", global::Agricoler.Properties.Resources.cow},
            {"horse", global::Agricoler.Properties.Resources.horse},
            {"fence", global::Agricoler.Properties.Resources.fence},
            {"playerBlue", global::Agricoler.Properties.Resources.playerBlue},
            {"playerRed", global::Agricoler.Properties.Resources.playerRed}
        };

        public static Bitmap Get(String name)
        {
            return icons[name];
        }
    }
}
