using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public interface ICollider : IDrawable
    {
        void intersect(Ball ball, Boxes box);
        void BallSpeed(Ball ball);
    }
}
