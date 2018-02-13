using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    class LineAsRect : Boxes
    {
        Size size;
        Rectangle rect;
        Point point;
        Pen pen;
        Color color;

        public LineAsRect(int x, int y, int width, int height, Color color) : this(new Size(width, height), new Point(x, y), color) { }

        public LineAsRect(Size size, Point point, Color color)
        {
            this.point = point;
            this.size = size;
            rect = new Rectangle(point, size);
            pen = new Pen(color);
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect);
        }

        
 
    }
}
