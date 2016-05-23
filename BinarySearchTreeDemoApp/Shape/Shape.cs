using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTreeDemoApp.GraphicsLib;
namespace BinarySearchTreeDemoApp.Shape
{
    public abstract class Shape
    {
        protected ShapeInfo shapInfo;

        public ShapeInfo ShapInfo
        {
            get { return shapInfo; }
            set { shapInfo = value; }
        }

        public abstract void draw(CommonGraphics graphics);

        
    }
}
