using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BinarySearchTreeDemoApp.GraphicsLib
{
    public class GdiPlusGraphics : CommonGraphics
    {
        private Graphics graphics;

        private Pen pen;

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }


        public GdiPlusGraphics(Graphics graphics)
        {
            this.graphics = graphics;
            this.pen = null;
        }

        public GdiPlusGraphics(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

    }
}
