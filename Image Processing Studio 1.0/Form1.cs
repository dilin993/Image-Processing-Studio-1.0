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

namespace Image_Processing_Studio_1._0
{
    public partial class Form1 : Form
    {
        Mat img;
        string imgPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPath = openFileDialog1.FileName;
                img = CvInvoke.Imread(imgPath);
                pictureBox1.Image = img.ToImage<Bgr, byte>().ToBitmap();
            }
        }

        private void sharpApplyClicked(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = sharpeningControl1.getProcessed(img);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
