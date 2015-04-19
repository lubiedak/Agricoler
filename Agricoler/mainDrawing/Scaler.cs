using System;

namespace Agricoler.mainDrawing
{
    /// <summary>
    /// This class is used to draw all elements in the board in proper scale
    /// </summary>
    public static class Scaler
    {
        static double baseWidth = 800.0;
        static double ratio = 1.0;
        public static double Ratio
        {
            get
            {
                return ratio;
            }
            set
            {
                ratio = Convert.ToDouble(value) / baseWidth;
            }
        }
    }
}
