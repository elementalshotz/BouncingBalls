using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public class Boxes : ICollider
    {
        Point position;
        Size size;
        Pen pen;
        public Rectangle rect;
        ChangeSpeed speed = new ChangeSpeed();

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

            Console.Write("ball.box.rect.X < (box.rect.X + box.rect.Width) " + (ball.box.rect.X < (box.rect.X + box.rect.Width)) + " ball.box.rect.Y > box.rect.Y" + (ball.box.rect.Y > box.rect.Y) + " ball.box.rect.Y < (box.rect.Y + box.rect.Height)" + (ball.box.rect.Y < (box.rect.Y + box.rect.Height)) + " ball.box.rect.X > box.rect.X" + (ball.box.rect.X > box.rect.X));

            if (ball.box.rect.X < (box.rect.X + box.rect.Width) || ball.box.rect.Y > box.rect.Y || ball.box.rect.Y < (box.rect.Y + box.rect.Height) || ball.box.rect.X > box.rect.X)
            {
                if (box.pen.Color == Color.Red)
                {
                    speed.METHOD = SpeedController.Method.multiply;

                    if (speed.changeOnce != 1)
                    {
                        speed.changeVector(vector, 2);
                        speed.changeOnce = 1;
                    }
                }
                else if (box.pen.Color == Color.Blue)
                {
                    speed.METHOD = SpeedController.Method.divide;

                    if (speed.changeOnce != 1)
                    {
                        speed.changeVector(vector, 2);
                        speed.changeOnce = 1;
                    }
                }
            } else
            {
                ball.Speed = vector;
            }
        }

        public void BallSpeed(Ball ball) { }
    }
}
