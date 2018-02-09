using System;
using System.Windows.Forms;


namespace BouncingBalls
{
	public class MainForm : Form
	{
		public MainForm() : base()
		{
			Text = "Bouncing Balls";
			Width = 800;
			Height = 600;
            DoubleBuffered = true;
		}
	}
}
