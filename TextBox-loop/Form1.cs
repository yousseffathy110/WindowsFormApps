using System.Text;

namespace TextBox_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create an empty array to store the textboxes
            TextBox[] textBoxArray = new TextBox[0];

            // loop over all the controls on the form
            foreach (Control control in this.Controls)
            {
                // check if the control is a TextBox
                if (control is TextBox)
                {
                    // resize the textBoxArray and add the TextBox to it
                    Array.Resize(ref textBoxArray, textBoxArray.Length + 1);
                    textBoxArray[textBoxArray.Length - 1] = (TextBox)control;
                }
            }
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            // create a StringBuilder object to store the entered text
            StringBuilder sb = new StringBuilder();

            // loop over all the TextBox controls on the form
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    // append the text of the TextBox to the StringBuilder
                    sb.AppendLine(((TextBox)control).Text);
                }
            }

            // display the entered text in a message box
            MessageBox.Show(sb.ToString());

            // terminate the program
            Application.Exit();
        }
    }
}