using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    interface ICollision : IDrawable
    {
        Point point { get; }
        void isInsideBox(Ball ball);
        void hitLine(Ball ball);
    }

}
