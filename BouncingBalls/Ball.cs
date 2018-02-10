using System;
using System.Drawing;

namespace BouncingBalls
{
	public class Ball : IDrawable
	{
		private Pen pen = new Pen(Color.White);
		private int radius;
        Point position;
        public Boxes box;

		public Ball(Point position, int radius)
		{
            this.position = position;
			this.radius = radius;
            box = new Boxes(new Point(position.X-radius, position.Y-radius), new Size(radius * 2, radius * 2), Color.Transparent);
		}

		public Ball(int x, int y, int radius) : this(new Point(x, y), radius)
		{
			this.radius = radius;
		}

		public void Draw(Graphics g)
		{
            box.Draw(g);
			g.DrawEllipse(pen,position.X - radius, position.Y - radius, 2 * radius, 2 * radius);
		}

		public void Move()
		{
			position.X = position.X + speed.X;
			position.Y = position.Y + speed.Y;
            box.Update(position,radius);
		}

		private Vector speed;

		public Vector Speed
		{
			get { return speed; }
			set { speed = value; }
		}
	}
}
