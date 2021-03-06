﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{
    /// <summary>
    /// This class has the basic structure required to draw a square.
    /// </summary>
    class Square
    {
        /// <summary>
        /// This method Draws the Square shape with the help of variables
        /// </summary>
        /// <param name="g"></param>
        /// <param name="outline"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="l"></param>
        public void Draw(Graphics g, Pen outline, int x, int y, int l)
        {
            g.DrawRectangle(outline, x, y, l, l);
        }
        /// <summary>
        /// This method fills the shape.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="fill_color"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="l"></param>
        public void fill(Graphics g, SolidBrush fill_color, int x, int y, int l)
        {
            g.FillRectangle(fill_color, x, y, l, l);
        }
    }
}
