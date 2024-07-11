using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ihatebmp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Bitmap Files|*.bmp"


            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog.FileName;
                Random rnd = new Random();
                int randomNum = rnd.Next(0,999999);
                string newName =  randomNum.ToString() + ".png";
                Image lol = Image.FromFile(Path.GetFullPath(openFileDialog.FileName));
                pictureBox1.Image = lol;
                try
                {
                    lol.Save(newName, ImageFormat.Png);
                    MessageBox.Show("Image file saved to " + newName.ToString(), "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch {
                    MessageBox.Show("Something went wrong");
                }
                
            }

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
