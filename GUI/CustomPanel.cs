﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class CustomPanel : Panel
    {
        //fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        Timer timer = new Timer();
        //Constructor
        public CustomPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 300);
            DoubleBuffered = true;
        }
        //Properties
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }
        public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
        public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; this.Invalidate(); } }

        

    }
}
