using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    class LineAsRect
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

        public void intersect(Ball ball, LineAsRect box)
        {
            if (ball.box.rect.IntersectsWith(box.rect))
            {
                if (color == Color.Yellow)
                {
                    if (ball.Speed.X > 0)
                    {
                        ball.Speed.X -= (2 * ball.Speed.X);
                    }
                    else
                    {
                        ball.Speed.X += (2 * ball.Speed.X);
                    }
                } else if (color == Color.Green)
                {
                    if (ball.Speed.Y > 0)
                    {
                        ball.Speed.Y -= (2 * ball.Speed.Y);
                    }
                    else
                    {
                        ball.Speed.Y += (2 * ball.Speed.Y);
                    }
                }
            }
        }
    }
}
