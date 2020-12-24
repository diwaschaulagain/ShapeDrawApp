using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{
    /// <summary>
    /// This class deals with filling the triangle
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// The polygon is filled.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="fill_color"></param>
        /// <param name="allpoints"></param>
        public void fill(Graphics g, SolidBrush fill_color, Point[] allpoints)
        {
            g.FillPolygon(fill_color, allpoints);
        }
    }
}
