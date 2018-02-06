using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    class Boxes : ICollision
    {
        private int x;
        private int y;
        private int length;
        private int height;


        public Boxes()
        {

        }

        public Boxes(int x, int y, int sides)         //Shape: Square
        {
            this.x = x;
            this.y = y;
            this.length = sides;
            this.height = sides;
        }

        public Boxes(int x, int y, int length, int height)  //Shape: Rectangle
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.height = height;
        }

        public void Draw(Graphics g)
        {
            
        }
    }
}
