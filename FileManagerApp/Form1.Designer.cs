namespace FileManagerApp
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
            lblPath = new Label();
            txtPath = new TextBox();
            btnBrowse = new Button();
            btnCreateFile = new Button();
            btnCreateFolder = new Button();
            btnDelete = new Button();
            lstFilesAndFolders = new ListBox();
            SuspendLayout();
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(49, 45);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(37, 20);
            lblPath.TabIndex = 0;
            lblPath.Text = "Path";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(92, 45);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(295, 27);
            txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(675, 36);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click_1;
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(675, 127);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(94, 29);
            btnCreateFile.TabIndex = 3;
            btnCreateFile.Text = "Create File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click_1;
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateFolder.Location = new Point(675, 207);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(94, 29);
            btnCreateFolder.TabIndex = 4;
            btnCreateFolder.Text = "CreateFolder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(675, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lstFilesAndFolders
            // 
            lstFilesAndFolders.FormattingEnabled = true;
            lstFilesAndFolders.ItemHeight = 20;
            lstFilesAndFolders.Location = new Point(92, 128);
            lstFilesAndFolders.Name = "lstFilesAndFolders";
            lstFilesAndFolders.Size = new Size(295, 264);
            lstFilesAndFolders.TabIndex = 6;
            lstFilesAndFolders.SelectedIndexChanged += lstFilesAndFolders_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstFilesAndFolders);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateFolder);
            Controls.Add(btnCreateFile);
            Controls.Add(btnBrowse);
            Controls.Add(txtPath);
            Controls.Add(lblPath);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPath;
        private TextBox txtPath;
        private Button btnBrowse;
        private Button btnCreateFile;
        private Button btnCreateFolder;
        private Button btnDelete;
        private ListBox lstFilesAndFolders;
    }
}