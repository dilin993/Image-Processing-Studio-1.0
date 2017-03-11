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
using System.Drawing.Imaging;

namespace Image_Processing_Studio_1._0
{
    public partial class Form1 : Form
    {
        Mat img;
        List<ImageHistory> imgList;
        const int CAPACITY = 100;
        int curIndex = -1;
        Image displayImage;

        // controls
        SharpeningControl sharpeningControl;

        public Form1()
        {
            InitializeComponent();
            imgList = new List<ImageHistory>(CAPACITY);
            openFileDialog1.Filter = GetImageFilter();

            // initialize user controls
            sharpeningControl = new SharpeningControl();
            sharpeningControl.Dock = DockStyle.Top;
            sharpeningControl.ApplyClicked += onProcessingApplyClicked;
        }

        public string GetImageFilter()
        {
            StringBuilder allImageExtensions = new StringBuilder();
            string separator = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            Dictionary<string, string> images = new Dictionary<string, string>();
            foreach (ImageCodecInfo codec in codecs)
            {
                allImageExtensions.Append(separator);
                allImageExtensions.Append(codec.FilenameExtension);
                separator = ";";
                images.Add(string.Format("{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension),
                           codec.FilenameExtension);
            }
            StringBuilder sb = new StringBuilder();
            if (allImageExtensions.Length > 0)
            {
                sb.AppendFormat("{0}|{1}", "All Images", allImageExtensions.ToString());
            }
            images.Add("All Files", "*.*");
            foreach (KeyValuePair<string, string> image in images)
            {
                sb.AppendFormat("|{0}|{1}", image.Key, image.Value);
            }
            return sb.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               foreach(string filename in openFileDialog1.FileNames)
                {
                    imgList.Add(new ImageHistory(filename));
                }
                if (curIndex < 0)
                    changeIndex(0);
                else
                    uiUpdate();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            uiUpdate();
        }

        private void reloadImage()
        {
            /// reload the img from scratch 
            /// redraw the image automatically
            if (curIndex < 0 || curIndex >= imgList.Count) return;
            try
            {
                img = CvInvoke.Imread(imgList[curIndex].Filename);
                char[] delimiterChars = { ','};

                foreach (string process in imgList[curIndex].History)
                {
                    img = ImageProcessor.getResult(img, process.Split(delimiterChars));
                }
                redrawImg();
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeIndex(int index)
        {
            if(index>=0 && index<imgList.Count)
            {
                curIndex = index;
                uiUpdate();
                if (img != null)
                    img.Dispose();
                reloadImage();
            }
        }

        private void updateDisplay()
        {
            /// Update the display of image with proper resizing
            if (displayImage == null) return;

            if(displayImage.Width<=pictureBox1.Width && displayImage.Height<=pictureBox1.Height)
            {
                pictureBox1.Image = displayImage;
                return;
            }
            double alpha = Math.Atan2(displayImage.Height, displayImage.Width);
            double beta = Math.Atan2(pictureBox1.Height, pictureBox1.Width);
            int width, height;
            if(alpha<beta)
            {
                width = pictureBox1.Width;
                height = (int)Math.Round(width * Math.Tan(alpha));
            }
            else
            {
                height = pictureBox1.Height;
                width = (int)Math.Round(height/ Math.Tan(alpha));
            }
          
            pictureBox1.Image = new Bitmap(displayImage, width, height);
        }
        

        private void uiUpdate()
        {
            if(imgList.Count<=0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnSharpen.Enabled = false;
                operationTab.Enabled = false;
            }
            else
            {
                if (curIndex + 1 < imgList.Count)
                    btnNext.Enabled = true;
                else
                    btnNext.Enabled = false;

                if (curIndex - 1 >= 0)
                    btnPrev.Enabled = true;
                else
                    btnPrev.Enabled = false;

                if(curIndex>=0 && curIndex<imgList.Count)
                {
                    operationTab.Enabled = true;
                    btnSharpen.Enabled = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changeIndex(curIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            changeIndex(curIndex - 1);
        }

        private void form1_resized(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(sharpeningControl);
        }

        private void onProcessingApplyClicked(object sender, EventArgs e)
        {
            try
            {
                ImageProcessingEventArgs ei = (ImageProcessingEventArgs)e;
                img = ImageProcessor.getResult(img, ei.Parameters);
                redrawImg();
                imgList[curIndex].History.Push(ei.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
