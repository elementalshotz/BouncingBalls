using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class RedBox : Boxes, ICollider
    {
        public RedBox(int x, int y, int sides) : base(x, y, sides, Color.Red) { }
        public RedBox(int x, int y, Size size) : base(x, y, size.Width, size.Height, Color.Red) { }

        public void BallSpeed(Ball ball)
        {
            ball.Speed.X *= 2;
            ball.Speed.Y *= 2;
        }

        public void intersect(Ball ball, Boxes box)
        {
            if (ball.box.rect.IntersectsWith(box.rect))
            {
                if ((ball.Speed.X) * 2 <= 10 && (ball.Speed.Y) * 2 <= 10)
                {
                    BallSpeed(ball);
                }
            }
        }
    }
}
