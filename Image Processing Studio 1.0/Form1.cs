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

        Image<Bgr, byte> My_Image;
        Image<Gray, byte> gray_image;
        Image<Gray, byte> img2Blue;
        Image<Gray, byte> img2Green;
        Image<Gray, byte> img2Red;

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
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                HistogramUpdate();
            }
        }

        private void sharpApplyClicked(object sender, EventArgs e)
        {
            try
            {
                My_Image = sharpeningControl1.getProcessed(img);
                pictureBox1.Image = My_Image.ToBitmap();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void HistogramUpdate()
        {
            try
            {
                My_Image = img.ToImage<Bgr, Byte>();
                gray_image = My_Image.Convert<Gray, byte>();
                img2Blue = My_Image[0];
                img2Green = My_Image[1];
                img2Red = My_Image[2];
                
                histogramBox1.ClearHistogram();
                DenseHistogram Hist = new DenseHistogram(256, new RangeF(0, 255));

                Mat m = new Mat();

                Hist.Calculate(new Image<Gray, byte>[] { gray_image }, false, null);
                Hist.CopyTo(m);
                histogramBox1.AddHistogram("Gray Histogram", Color.Black, m, 256, new float[] { 0, 256 });

                Hist.Calculate(new Image<Gray, byte>[] { img2Blue }, false, null);
                Hist.CopyTo(m);
                histogramBox1.AddHistogram("Blue Histogram", Color.Blue, m, 256, new float[] { 0, 256 });

                Hist.Calculate(new Image<Gray, byte>[] { img2Green }, false, null);
                Hist.CopyTo(m);
                histogramBox1.AddHistogram("Green Histogram", Color.Green, m, 256, new float[] { 0, 256 });

                Hist.Calculate(new Image<Gray, byte>[] { img2Red }, false, null);
                Hist.CopyTo(m);
                histogramBox1.AddHistogram("Red Histogram", Color.Red, m, 256, new float[] { 0, 256 });
                histogramBox1.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
