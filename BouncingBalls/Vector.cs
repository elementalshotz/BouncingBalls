using System;
namespace BouncingBalls
{
	public class Vector
	{
		private int x;
		private int y;

		public Vector(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}
        
		public int Y
		{
			get { return y; }
			set { y = value; }
		}

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y);
        }

        public static Vector operator /(Vector v1, Vector v2)
        {
            return new Vector(v1.X / v2.X, v1.Y / v2.Y);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return (v1.X != v2.Y) && (v1.Y != v2.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return (v1.X == v2.X) && (v1.Y == v2.Y);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -624234986;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
