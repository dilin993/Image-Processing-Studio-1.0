using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace Image_Processing_Studio_1._0
{
    public partial class SharpeningControl : UserControl
    {

        private const double MIN_SIGMA = 0.0;
        private const double MAX_SIGMA = 21.0;
        private const double MIN_AMOUNT = 0.0;
        private const double MAX_AMOUNT = 2.6;
        private const double DEFAULT_SIGMA = 3.0;
        private const double DEFAULT_AMOUNT = 1.0;
        double sigma;
        double amount;
        public event EventHandler ApplyClicked;

        public SharpeningControl()
        {
            InitializeComponent();
        }




        public Image getProcessed(Mat img)
        {
            Mat dblImg = new Mat(img.Rows,img.Cols,Emgu.CV.CvEnum.DepthType.Cv64F,img.NumberOfChannels);
            Mat dblBlurImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            Mat outImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            int k = 2*(int)Math.Round(3.0*sigma)+1;
            CvInvoke.GaussianBlur(dblImg, dblBlurImg, new Size(k, k), sigma, sigma);
            CvInvoke.AddWeighted(dblImg,1.0+amount,dblBlurImg,-amount,0,outImg);
            return outImg.ToImage<Bgr, byte>().ToBitmap();
        }

        private void SharpeningControl_Load(object sender, EventArgs e)
        {
            tbSigma.Value = (int)Math.Round((DEFAULT_SIGMA - MIN_SIGMA) * (tbSigma.Maximum - tbSigma.Minimum) /
                (tbSigma.TickFrequency * (MAX_SIGMA - MIN_SIGMA)));
            sigma = tbSigma.Value * tbSigma.TickFrequency * 
                (MAX_SIGMA - MIN_SIGMA) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_SIGMA; ;
            lbSigma.Text = sigma.ToString();

            tbAmount.Value = (int)Math.Round((DEFAULT_AMOUNT - MIN_AMOUNT) * (tbAmount.Maximum - tbAmount.Minimum) /
                (tbAmount.TickFrequency * (MAX_AMOUNT - MIN_AMOUNT)));
            amount = tbAmount.Value * tbAmount.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_AMOUNT; ;
            lbAmount.Text = amount.ToString();
        }

        private void tbSigma_Scroll(object sender, EventArgs e)
        {
            sigma = tbSigma.Value * tbSigma.TickFrequency *
               (MAX_SIGMA - MIN_SIGMA) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_SIGMA;
            lbSigma.Text = sigma.ToString();
        }

        private void tbAmount_Scroll(object sender, EventArgs e)
        {
            amount = tbAmount.Value * tbAmount.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_AMOUNT; ;
            lbAmount.Text = amount.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyClicked != null)
            {
                string[] parameters = {ImageProcessingTypes.Sharpening,
                sigma.ToString(), amount.ToString()};
                this.ApplyClicked(this,
                    new ImageProcessingEventArgs(parameters));
            }
                

        }

       
    }

    

}
