using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public class Boxes
    {
        Point position;
        Size size;
        Pen pen;
        Rectangle rect;
        int hasMultiplied = 0;

        public Boxes()
        {

        }

        public Boxes(int x, int y, int sides, Color color) : this(x, y, sides, sides, color)         //Shape: Square
        {}

        public Boxes(int x, int y, int length, int height, Color color) : this(new Point(x, y), new Size(length, height), color) //Shape: Rectangle
        {}

        public Boxes(Point point, Size size, Color color)
        {
            position = point;
            this.size = size;
            pen = new Pen(color);
            rect = new Rectangle(point, size);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect);
        }

        public void Update(Point position, int radius)
        {
            this.position = position;
            rect.X = position.X - radius;
            rect.Y = position.Y - radius;
        }

        public void intersect(Ball ball, Boxes box)
        {
            Vector vector = new Vector(ball.Speed.X, ball.Speed.Y);

            if (ball.box.rect.IntersectsWith(box.rect) && box.pen.Color == Color.Red && ball.box.rect.Top > box.rect.Top)
            {
                if (hasMultiplied == 0)
                {
                    ball.Speed.X = (int)Decimal.Multiply(ball.Speed.X, (decimal)1.5);
                    ball.Speed.Y = (int)Decimal.Multiply(ball.Speed.Y, (decimal)1.5);
                    hasMultiplied = 1;
                }
            } else if (ball.box.rect.IntersectsWith(box.rect) && box.pen.Color == Color.Blue)
            {
                
            } else
            {
                ball.Speed = vector;
            }
        }

        public Point point { get { return position; } }
    }
}
