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

        Boxes box = new Boxes(500, 30, 200, Color.Red);
        Boxes rect = new Boxes(50, 100, 100, 300, Color.Blue);

        Lines line1 = new Lines(0, 550, 800, 550, Color.Green);
        Lines Line2 = new Lines(775, 0, 775, 800, Color.Yellow);
        Lines Line3 = new Lines(10, 0, 10, 800, Color.Yellow);
        Lines Line4 = new Lines(0, 10, 800, 10, Color.Green);
        Lines Line5 = new Lines(580, 250, 580, 450, Color.Yellow);
        

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
            if (balls.Count < 100) if (random.Next(100) < 25) AddBall();

			foreach (var ball in balls)
			{
				ball.Move();
                ball.box.intersect(ball, box);
                ball.box.intersect(ball, rect);
            }

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
            line1.Draw(args.Graphics);
            Line2.Draw(args.Graphics);
            Line3.Draw(args.Graphics);
            Line4.Draw(args.Graphics);
            Line5.Draw(args.Graphics);
            
		}

	}
}
