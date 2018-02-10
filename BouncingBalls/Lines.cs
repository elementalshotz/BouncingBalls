using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class Lines
    {
        Pen pen;
        Point pointOne;
        Point pointTwo;

        public Lines(int x1, int y1, int x2, int y2, Color color) : this(new Point(x1, y1), new Point(x2, y2), color)
        {
            
        }

        public Lines(Point p1, Point p2, Color color)
        {
            pointOne = p1;
            pointTwo = p2;
            pen = new Pen(color);
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(pen, pointOne, pointTwo);
        }

        public Point point { get; }

    }
}
