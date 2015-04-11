﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agricoler
{
    public partial class Agricoler : Form
    {
        MainResizer mainResizer;

        public Agricoler()
        {
            InitializeComponent();
            mainResizer = new MainResizer(this);
        }

        private void Agricoler_ResizeEnd(object sender, EventArgs e)
        {
            mainResizer.Resize(this);
        }
    }
}
