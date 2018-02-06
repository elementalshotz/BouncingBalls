using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BouncingBalls
{
	public class Engine
	{
		private MainForm form;
		private Timer timer;

		private ISet<Ball> balls = new HashSet<Ball>();

		private Random random = new Random();

        Boxes box = new Boxes(100, 50, 200, Boxes.ShapeColor.Red);
        Boxes rect = new Boxes(50, 100, 100, 300, Boxes.ShapeColor.Blue);

        public Engine()
		{
			form = new MainForm();
			timer = new Timer();

			AddBall();
		}

		public void Run()
		{
			form.Paint += new PaintEventHandler(Draw);

			timer.Tick += new EventHandler(TimerEventHandler);
			timer.Interval = 1000/25;
			timer.Start();

            Application.Run(form);
		}

		private void AddBall()
		{
			var ball = new Ball(400, 300, 10);
			ball.Speed = new Vector(random.Next(10) - 5, random.Next(10) - 5);
			balls.Add(ball);
		}

		private void TimerEventHandler(Object obj, EventArgs args)
		{
			if (random.Next(100) < 25) AddBall();

			foreach (var ball in balls)
			{
				ball.Move();
            }

            Boxes.balls = balls;

            rect.Collision();
            box.Collision();

            form.Refresh();
		}

		private void Draw(Object obj, PaintEventArgs args)
		{
			foreach (var ball in balls)
			{
				ball.Draw(args.Graphics);
			}

            box.Draw(args.Graphics);
            rect.Draw(args.Graphics);
		}

	}
}
