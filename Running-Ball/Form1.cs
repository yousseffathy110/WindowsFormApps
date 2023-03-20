namespace Running_Ball
{
    public partial class Form1 : Form
    {
        private int ballSpeed = 5;
        private int ballDirection = 1; // 1 for right, -1 for left
        private Point ballPosition = new Point(50, 50);
        private Size ballSize = new Size(20, 20);
        private Rectangle stick1 = new Rectangle(20, 100, 10, 200);
        private Rectangle stick2 = new Rectangle(470, 100, 10, 200);
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update ball position
            ballPosition.X += ballSpeed * ballDirection;
            ballPictureBox.Location = ballPosition;

            // Check for collisions with sticks
            if (ballPictureBox.Bounds.IntersectsWith(stick1))
            {
                ballDirection = 1;
            }
            else if (ballPictureBox.Bounds.IntersectsWith(stick2))
            {
                ballDirection = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ballPictureBox.Size = ballSize;
            ballPictureBox.Location = ballPosition;
            stick1PictureBox.BackColor = Color.Black;
            stick1PictureBox.Size = stick1.Size;
            stick1PictureBox.Location = stick1.Location;
            stick2PictureBox.BackColor = Color.Black;
            stick2PictureBox.Size = stick2.Size;
            stick2PictureBox.Location = stick2.Location;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}