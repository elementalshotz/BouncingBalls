using System.Windows.Forms;

namespace BouncingBalls
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Engine engine = new Engine(); /* Runs the bouncing balls application */
			engine.Run();
		}
	}
}
