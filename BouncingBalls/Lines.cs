using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class Lines : ICollision
    {
        private int length;
        private int y;
        
        public enum LineColor { yellow,green }

        public void Draw(Graphics g)
        {
            //g.DrawLine(pen,length );
        }

        public Lines (int length, LineColor color )
        {

        }

        public void Collision (Ball ball)
        {

        }
        
       
    }
}
