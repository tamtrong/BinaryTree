using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTreeDemoApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

        }
        Graphics g;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }
        Line n = new Line();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawLine(new Pen(Color.Red, 4), new Point(100, 200), new Point(300, 400));

            n.Draw(g);
            
        }

        
    }
}
