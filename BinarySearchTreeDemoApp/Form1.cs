using MetroFramework.Forms;
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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        private Point begin = new Point(100, 200);
        Graphics g;
        private Point current = new Point(100, 200);
        private Point end = new Point(300, 400);
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawLine(new Pen(Color.Red, 4), new Point(begin.X, begin.Y), new Point(300, 400));

            if (current != end)
            {
                g.DrawLine(new Pen(Color.Green, 6), new Point(begin.X, begin.Y), new Point(current.X, current.Y));
                current.X++;
                current.Y++;
            }
            else
            {
                timer1.Enabled = false;
                current.X = 100;
                current.Y = 200;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //this.splitContainer1.Panel2.Invalidate();
           
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }


       
    }
}
