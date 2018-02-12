using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public class ChangeSpeed : SpeedController
    {
        public int changeOnce = 0;

        public ChangeSpeed() : base(new Vector(0, 0), Method.divide) { }
        public ChangeSpeed(Vector v, Method method) : base(v, method) { }
        public ChangeSpeed(Vector v, Method method, int change) : base(v, method, change) { }

        public Vector changeVector(Vector v, int change)
        {
            base.Change += change;

            if (base.method == Method.divide)
            {
                base.newVector = new Vector(v.X / change, v.Y / change);
            } else
            {
                base.newVector = new Vector(v.X * change, v.Y * change);
            }

            return base.newVector;
        }
    }
}
