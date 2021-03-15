using System;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "No File Selected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Vraj\\Pictures";
            openFileDialog.Filter = "PNG files (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog.Title = "Choose Picture";
            openFileDialog.ShowDialog();
            if ((int)DialogResult.OK == 1)
            {
                location = openFileDialog.FileName;
                label1.Text = location;
                pictureBox1.ImageLocation = location;
            }

        }
    }
}
