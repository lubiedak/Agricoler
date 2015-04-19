using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agricoler.mainDrawing;

namespace Agricoler
{
    public partial class Agricoler : Form
    {
        MainResizer mainResizer;
        MainDrawer mainDrawer;

        public Agricoler()
        {
            InitializeComponent();
            mainResizer = new MainResizer(this);
            mainDrawer = new MainDrawer();
        }

        private void Agricoler_SizeChanged(object sender, EventArgs e)
        {
            mainResizer.Resize(this);
            Scaler.Ratio = mainBoard.Width;
        }

        private void mainBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            mainDrawer.Draw(g);
        }
    }
}
