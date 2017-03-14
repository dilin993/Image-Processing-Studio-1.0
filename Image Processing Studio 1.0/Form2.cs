using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using ZedGraph;

namespace Image_Processing_Studio_1._0
{
    public partial class Form2 : Form
    {
        UMat img;
        Image displayImage;

        public Form2()
        {
            InitializeComponent();
            img = Form1.img_crop;
            redrawImg();
        }

        private void updateDisplay()
        {
            /// Update the display of image with proper resizing
            if (displayImage == null) return;

            if (displayImage.Width <= pictureBox1.Width && displayImage.Height <= pictureBox1.Height)
            {
                pictureBox1.Image = displayImage;
                return;
            }
            double alpha = Math.Atan2(displayImage.Height, displayImage.Width);
            double beta = Math.Atan2(pictureBox1.Height, pictureBox1.Width);
            int width, height;
            if (alpha < beta)
            {
                width = pictureBox1.Width;
                height = (int)Math.Round(width * Math.Tan(alpha));
            }
            else
            {
                height = pictureBox1.Height;
                width = (int)Math.Round(height / Math.Tan(alpha));
            }

            pictureBox1.Image = new Bitmap(displayImage, width, height);
        }

        private void redrawImg()
        {
            /// Redraw the image from the mat img
            /// updateDIsplay automatically
            if (img == null) return;
            try
            {
                displayImage = img.ToImage<Bgr, byte>().ToBitmap();

                updateDisplay();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
