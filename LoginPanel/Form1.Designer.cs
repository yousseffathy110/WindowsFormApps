namespace LoginPanel
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
            username = new System.Windows.Forms.TextBox();
            btn = new System.Windows.Forms.Button();
            usernamelabel = new System.Windows.Forms.Label();
            passwordlabel = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new System.Drawing.Point(155, 121);
            username.Name = "username";
            username.Size = new System.Drawing.Size(175, 27);
            username.TabIndex = 0;
            username.TextChanged += username_TextChanged;
            // 
            // btn
            // 
            btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn.Location = new System.Drawing.Point(170, 362);
            btn.Name = "btn";
            btn.Size = new System.Drawing.Size(94, 29);
            btn.TabIndex = 1;
            btn.Text = "Submit";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            usernamelabel.Location = new System.Drawing.Point(31, 123);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new System.Drawing.Size(105, 25);
            usernamelabel.TabIndex = 2;
            usernamelabel.Text = "User Name";
            usernamelabel.Click += usernamelabel_Click;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            passwordlabel.Location = new System.Drawing.Point(31, 249);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new System.Drawing.Size(101, 28);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(155, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(175, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(453, 499);
            Controls.Add(textBox1);
            Controls.Add(passwordlabel);
            Controls.Add(usernamelabel);
            Controls.Add(btn);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
