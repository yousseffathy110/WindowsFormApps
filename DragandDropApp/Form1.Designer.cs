namespace DragandDropApp
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
            rectangle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)rectangle).BeginInit();
            SuspendLayout();
            // 
            // rectangle
            // 
            rectangle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            rectangle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rectangle.Location = new System.Drawing.Point(242, 150);
            rectangle.Name = "rectangle";
            rectangle.RowHeadersWidth = 51;
            rectangle.RowTemplate.Height = 29;
            rectangle.Size = new System.Drawing.Size(240, 129);
            rectangle.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(rectangle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rectangle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView rectangle;
    }
}
