using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            using (StreamReader sdr = new StreamReader(@"C:\Users\Vraj\Desktop\#\Handson\C# Advanced Concepts\AsyncAwait2\AsyncAwait2\TextFile1.txt"))
            {
                label1.Text = "Processing....";
                string result = await Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    return sdr.ReadToEndAsync();
                });
                count = result.Length;
            }
            label1.Text = count.ToString() + " Characters in file";
        }
    }
}
