﻿using System;
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
	}
}
