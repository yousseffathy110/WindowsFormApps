namespace Running_Ball
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            stick1PictureBox = new PictureBox();
            stick2PictureBox = new PictureBox();
            ballPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)stick1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stick2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ballPictureBox).BeginInit();
            SuspendLayout();
            // 
            // stick1PictureBox
            // 
            stick1PictureBox.BackColor = SystemColors.Highlight;
            stick1PictureBox.Location = new Point(765, 134);
            stick1PictureBox.Name = "stick1PictureBox";
            stick1PictureBox.Size = new Size(23, 139);
            stick1PictureBox.TabIndex = 0;
            stick1PictureBox.TabStop = false;
            // 
            // stick2PictureBox
            // 
            stick2PictureBox.BackColor = SystemColors.Highlight;
            stick2PictureBox.Location = new Point(12, 134);
            stick2PictureBox.Name = "stick2PictureBox";
            stick2PictureBox.Size = new Size(25, 139);
            stick2PictureBox.TabIndex = 1;
            stick2PictureBox.TabStop = false;
            stick2PictureBox.Click += pictureBox2_Click;
            // 
            // ballPictureBox
            // 
            ballPictureBox.BackColor = Color.FromArgb(128, 255, 128);
            ballPictureBox.Location = new Point(325, 174);
            ballPictureBox.Name = "ballPictureBox";
            ballPictureBox.Size = new Size(85, 60);
            ballPictureBox.TabIndex = 2;
            ballPictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ballPictureBox);
            Controls.Add(stick2PictureBox);
            Controls.Add(stick1PictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)stick1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)stick2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ballPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox stick1PictureBox;
        private PictureBox stick2PictureBox;
        private PictureBox ballPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}