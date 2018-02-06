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
        private int x;
        private int y;
        private int length;
        private int height;
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
            this.x = x;
            this.y = y;
            this.length = length;
            this.height = height;

            switch (color)
            {
                case (ShapeColor.Blue):
                    pen = new Pen(Color.Blue);
                    break;
                case (ShapeColor.Red):
                    pen = new Pen(Color.Red);
                    break;
            }

            rect = new Rectangle(x, y, length, height);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect);
        }

        public void Collision(Ball ball)
        {

        }
    }
}
