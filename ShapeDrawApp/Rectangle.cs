using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{
    class Rectangle
    {
        public void Draw(Graphics g, Pen outline, int x, int y, int l, int j)
        {
            g.DrawRectangle(outline, x, y, l, j);
        }
        public void fill(Graphics g, SolidBrush fill_color, int x, int y, int l, int j)
        {
            g.FillRectangle(fill_color, x, y, l, j);
        }
    }
}
