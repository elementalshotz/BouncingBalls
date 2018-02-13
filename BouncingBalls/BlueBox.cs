using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class BlueBox : Boxes, ICollider
    {
        public BlueBox(int x, int y, int sides) : base(x, y, sides, Color.Blue) { }
        public BlueBox(int x, int y, Size size) : base(x, y, size.Width, size.Height, Color.Blue) { }

        public void BallSpeed(Ball ball)
        {
            ball.Speed.X /= 2;
            ball.Speed.Y /= 2;
        }

        public void intersect(Ball ball, Boxes box)
        {
            if (ball.box.rect.IntersectsWith(box.rect))
            {
                if ((ball.Speed.X) / 2 != 0 && (ball.Speed.Y) / 2 != 0)
                {
                    BallSpeed(ball);
                }
            }
        }
    }
}
