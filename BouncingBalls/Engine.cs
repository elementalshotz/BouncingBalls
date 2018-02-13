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

        RedBox box = new RedBox(500, 30, 200);
        BlueBox rect = new BlueBox(50, 200, new Size(100, 300));

        HLine line1 = new HLine(0, 550, 800, 1);
        VLine line2 = new VLine(775, 0, 1, 800);
        HLine line3 = new HLine(0, 5, 800, 1);
        VLine line4 = new VLine(10, 0, 1, 800);
        VLine line5 = new VLine(580, 250, 1, 150); //Test line somewhere inside the box of lines
        HLine line6 = new HLine(50, 100, 200, 1);

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
            if (balls.Count < 1000) if (random.Next(100) < 25) AddBall();

			foreach (var ball in balls)
			{
				ball.Move();
                box.intersect(ball, box);
                rect.intersect(ball, rect);

                line2.intersect(ball, line2);
                line4.intersect(ball, line4);
                line5.intersect(ball, line5);

                line1.intersect(ball, line1);
                line3.intersect(ball, line3);
                line6.intersect(ball, line6);
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

            line.Draw(args.Graphics);
            line2.Draw(args.Graphics);
            line3.Draw(args.Graphics);
            line4.Draw(args.Graphics);
            line5.Draw(args.Graphics);
            line6.Draw(args.Graphics);
		}

	}
}
