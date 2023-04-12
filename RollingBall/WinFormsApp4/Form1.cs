using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        private int x = 100; // starting x coordinate of the ball
        private int y = 50; // starting y coordinate of the ball
        private int speed = 3; // speed of the ball
        private int ballSize = 50; // size of the ball
        private Timer timer1;
        public Form1()
        {
            this.ClientSize = new Size(500, 500); // set the size of the form
            InitializeComponent();
            // create and configure the timer
            timer1 = new Timer();
            timer1.Interval = 20; // update the ball position every 20 milliseconds
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

            this.Paint += new PaintEventHandler(Form1_Paint); // add a paint event handler to draw the ball
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // update the x coordinate of the ball
            x += speed;

            // if the ball goes beyond the right edge of the form, reverse its direction
            if (x > this.ClientSize.Width - ballSize-100)
            {
                speed = -speed;
                x = this.ClientSize.Width - ballSize-100;
            }

            // if the ball goes beyond the left edge of the form, reverse its direction
            if (x <100)
            {
                speed = -speed;
                x = 100;
            }

            this.Invalidate(); // force the form to repaint itself
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // create a graphics object to draw the ball
            Graphics g = e.Graphics;

            // create a brush to fill the ball with a color
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 90, y,10,50);
            g.FillRectangle(brush, Width-110, y,10,50);
            // draw the ball at the current position
            g.FillEllipse(brush, x, y, ballSize, ballSize);

            // dispose the brush and graphics objects
            brush.Dispose();
            g.Dispose();
        }


        

    }
}
