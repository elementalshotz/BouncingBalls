using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    class Boxes : ICollision
    {
        Point position;
        Size size;
        Pen pen;
        Rectangle rect;
        public enum ShapeColor { Red, Blue }

        public Boxes()
        {

        }

        public Boxes(int x, int y, int sides, ShapeColor color) : this(x, y, sides, sides, color)         //Shape: Square
        {}

        public Boxes(int x, int y, int length, int height, ShapeColor color)  //Shape: Rectangle
        {
            position = new Point(x, y);
            size = new Size(length, height);

            switch (color)
            {
                case (ShapeColor.Blue):
                    pen = new Pen(Color.Blue);
                    break;
                case (ShapeColor.Red):
                    pen = new Pen(Color.Red);
                    break;
            }

            rect = new Rectangle(position, size);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect);
        }

        public Point point { get { return position; } }

        public void isInsideBox(Ball ball)
        {

        }

        public void hitLine(Ball ball)
        {

        }
    }
}
