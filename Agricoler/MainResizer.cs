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

        public MainResizer(Form f)
        {
            marginWidth = 16;
            marginHeight = 62;
            lastWidth = f.Width;
            lastHeight = f.Height;
        }

        public void Resize(Form f)
        {
            if ((f.Height - lastHeight) > (f.Width - lastWidth))
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
