using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class VLine : LineAsRect, ICollider
    {
        public VLine(int x, int y, int width, int height) : base(x, y, width, height, Color.Yellow) { }

        public void intersect(Ball ball, Boxes box) {
            if (ball.box.rect.IntersectsWith(box.rect))
                BallSpeed(ball);
        }

        public void BallSpeed(Ball ball)
        {
            ball.Speed.X *= -1;
        }
    }
}
