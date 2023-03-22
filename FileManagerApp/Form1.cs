using System;
using System.IO;
using System.Windows.Forms;



namespace FileManagerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void LoadFilesAndFolders()
        {
            if (string.IsNullOrEmpty(txtPath.Text) || !Directory.Exists(txtPath.Text))
            {
                return;
            }

            lstFilesAndFolders.Items.Clear();

            var dirs = Directory.GetDirectories(txtPath.Text);
            foreach (string dir in dirs)
            {
                lstFilesAndFolders.Items.Add(Path.GetFileName(dir));
            }

            var files = Directory.GetFiles(txtPath.Text);
            foreach (string file in files)
            {
                lstFilesAndFolders.Items.Add(Path.GetFileName(file));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    LoadFilesAndFolders();
                }
            }
        }

        private void btnCreateFile_Click_1(object sender, EventArgs e)
        {
            //string fileName = $"NewFile_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("Enter a filename:", "Create File", "NewFile.txt");
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }
            string filePath = Path.Combine(txtPath.Text, fileName);

            File.Create(filePath).Close();
            LoadFilesAndFolders();
        }

        private void btnCreateFolder_Click_1(object sender, EventArgs e)
        {
            //string folderName = $"NewFolder_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}";
            string folderName = Microsoft.VisualBasic.Interaction.InputBox("Enter a folder name:", "Create Folder", "NewFolder");
            if (string.IsNullOrWhiteSpace(folderName))
            {
                return;
            }
            string folderPath = Path.Combine(txtPath.Text, folderName);

            Directory.CreateDirectory(folderPath);
            LoadFilesAndFolders();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (lstFilesAndFolders.SelectedItem == null)
            {
                MessageBox.Show("Please select a file or folder to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedItem = lstFilesAndFolders.SelectedItem.ToString();
            string fullPath = Path.Combine(txtPath.Text, selectedItem);

            if (Directory.Exists(fullPath))
            {
                Directory.Delete(fullPath, true);
            }
            else if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            LoadFilesAndFolders();
        }

        private void lstFilesAndFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}