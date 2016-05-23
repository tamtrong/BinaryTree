using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeDemoApp
{
    public class Line
    {

        private Point begin = new Point(100, 200);
        private Point current = new Point(100, 200);
        private Point end = new Point(300, 400);
        private Pen p = new Pen(Color.Green, 6); 
        public void Draw(Graphics g)
        {
            if (current != end)
            {
                g.DrawLine(p, begin, current);
                current.X++;
                current.Y++;
            }
            else
            {

                current.X = 100;
                current.Y = 200;
            }
        }
    }
}
