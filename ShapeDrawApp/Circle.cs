﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{
   public class Circle
    {
        public void Draw(Graphics g, Pen outline, int x, int y, int l)
        {
            g.DrawEllipse(outline, x, y, l, l);
        }
        public void fill(Graphics g, SolidBrush fill_color, int x, int y, int l)
        {
            g.FillEllipse(fill_color, x, y, l, l);
        }
                               
    }
}
