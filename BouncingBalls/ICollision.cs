using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    interface ICollision : IDrawable
    {
        void Collision();
        
    }

}
