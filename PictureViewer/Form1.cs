using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // user can choose to close software/application using 'close' button
        private void closeBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // user can choose to display a background color before choosing a picture
        private void backgroundColorBUTTON_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }
        // allows user to clear the picture from display
        private void clearPictureBUTTON_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        // provide user means to choose a picture and dislpay it based off IMAGE type filter
        private void displayPictureBUTTON_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        // for user to set image size to fit screen
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            { 
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
