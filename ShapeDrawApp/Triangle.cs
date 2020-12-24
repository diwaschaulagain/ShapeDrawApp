using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{
    class Triangle
    {
        public void fill(Graphics g, SolidBrush fill_color, Point[] allpoints)
        {
            g.FillPolygon(fill_color, allpoints);
        }
    }
}
