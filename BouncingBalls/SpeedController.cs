using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public class SpeedController
    {
        protected static Vector orgVector;
        protected Vector newVector;
        protected int Change;
        public enum Method { multiply, divide }
        protected Method method;
        
        public SpeedController(Vector v)
        {
            orgVector = new Vector(v.X, v.Y);
            newVector = new Vector(v.X, v.Y);
            Change = 0;
        }

        public SpeedController(Vector v, Method method) : this(v, method, 0) {}

        public SpeedController(Vector v, Method method, int change)
        {
            orgVector = new Vector(v.X, v.Y);
            newVector = new Vector(v.X, v.Y);
            Change = change;
            this.method = method;
        }

        public Method METHOD
        {
            get { return method; }
            set { method = value; }
        }
    }
}
