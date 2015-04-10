using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agricoler
{
    class MainResizer
    {
        int marginWidth;
        int marginHeight;

        int lastWidth;
        int lastHeight;

        double ratio;

        public MainResizer()
        {
            marginWidth = 16;
            marginHeight = 62;
            lastWidth = 656;
            lastHeight = 522;

        }

        public void Resize(Form f)
        {
            if ((f.Height - lastHeight) > (f.Width - lastWidth))
            //Check for which one is resized more height/width
            {
                f.Width = (int)(640 * (f.Height-marginHeight)/460 + marginWidth);
            }
            else
            {
                f.Height = (int)( 460 * (f.Width - marginWidth) / 640 + marginHeight);
            }

            lastWidth = f.Width;
            lastHeight = f.Height;
        }

    }
}
