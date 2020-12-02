using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waldo_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo(@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics");
            if (di.Exists)
            {
                updateInfo();
                return;
            }
        }

        private void updateInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics");
            string firstFileName = di.GetFiles().Select(fi => fi.Name).FirstOrDefault(name => name != "Thumbs.db");
            Image image = Image.FromFile(@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics\" + firstFileName);
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void noBT_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Height = 0;
            pictureBox1.Width = 0;
            DirectoryInfo di = new DirectoryInfo
                (@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics");
            string firstFileName = di.GetFiles().Select(fi => fi.Name).FirstOrDefault(name => name != "Thumbs.db");
            string currentFolder = 
                (@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics\" + firstFileName);
            
            string destFolder = 
                (@"D:\csResources\Smaller Projects\WaldoTester\Not_Waldo\" + firstFileName);
       
            File.Move(currentFolder, destFolder);
            updateInfo();

        }

        private void yesBT_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            DirectoryInfo di = new DirectoryInfo
               (@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics");
            string firstFileName = di.GetFiles().Select(fi => fi.Name).FirstOrDefault(name => name != "Thumbs.db");
            string currentFolder =
                (@"D:\csResources\Smaller Projects\WaldoTester\Untested_Pics\" + firstFileName);
            string destFolder =
                (@"D:\csResources\Smaller Projects\WaldoTester\Waldo\" + firstFileName);
            File.Move(currentFolder, destFolder);
            updateInfo();
        }
    }
}
