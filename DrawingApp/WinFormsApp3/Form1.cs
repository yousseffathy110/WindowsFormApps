using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Timers;

namespace WinFormsApp3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = -1, y = -1;
        bool moving = false;
        Graphics g;
        Brush brush;
        Rectangle rect3;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 634);
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Black);

        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                brush = new SolidBrush(Color.Yellow);
            }
            else
            {
                brush = new SolidBrush(BackColor);
            }
            moving = true;
            x = e.X;
            y = e.Y;   

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if(moving && x!= -1 && y != -1)
            {
                x = e.X;
                y = e.Y;
                rect3 = new Rectangle(x - 25, y - 25, 50, 50);
                g.FillEllipse(brush, rect3);
            }
        }














        /*var gfx = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.Black);
            Rectangle rect3 = new Rectangle(e.X - 25, e.Y - 25, 50, 50);
            gfx.FillEllipse(brush, rect3);*/
    }
}
