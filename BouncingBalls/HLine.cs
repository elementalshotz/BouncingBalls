using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class HLine :LineAsRect,ICollider
    {
        public HLine(int x, int y, int width, int height) : base(x, y, width, height, Color.Green) { }

        public void intersect(Ball ball, Boxes box)
        {
            if (ball.box.rect.IntersectsWith(box.rect))
                BallSpeed(ball);
        }

        public void BallSpeed(Ball ball)
        {
            ball.Speed.Y *= -1;
        }

    }
}
