using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawApp
{/// <summary>
/// Basics of circle drawing is done in this class
/// </summary>
   public class Circle
    {/// <summary>
    /// This method Draws the ellipse shape with the help of variables
    /// </summary>
    /// <param name="g"></param>
    /// <param name="outline"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="l"></param>
        public void Draw(Graphics g, Pen outline, int x, int y, int l)
        {
            g.DrawEllipse(outline, x, y, l, l);
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
            g.FillEllipse(fill_color, x, y, l, l);
        }
                               
    }
}
