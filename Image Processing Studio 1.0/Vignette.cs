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
    public partial class Vignette : UserControl
    {

        private const double MIN_RAD = 5.0;
        private const double MAX_RAD = 9.0;
        private const double MIN_INTENSITY = -255.0;
        private const double MAX_INTENSITY = 255.0;
        private const double DEFAULT_RAD = 7.0;
        private const double DEFAULT_INTENSITY = 200.0;
        double radi;
        double intensity;
        public event EventHandler ApplyClicked;
        

        public Vignette()
        {
            InitializeComponent();
        }




        public Image getProcessed(Mat img)
        {
            //Mat dblImg = new Mat(img.Rows,img.Cols,Emgu.CV.CvEnum.DepthType.Cv64F,img.NumberOfChannels);
            //Mat dblBlurImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            //Mat outImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            //img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            //int k = 2*(int)Math.Round(3.0*radi)+1;
            //CvInvoke.GaussianBlur(dblImg, dblBlurImg, new Size(k, k), radi, radi);
            //CvInvoke.AddWeighted(dblImg,1.0+intensity,dblBlurImg,-intensity,0,outImg);
            //return outImg.ToImage<Bgr, byte>().ToBitmap();

            
            Mat dblImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            Mat outImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            img.ConvertTo(outImg, Emgu.CV.CvEnum.DepthType.Cv64F);

            Image<Bgr, Byte> a = outImg.ToImage<Bgr, Byte>();

            Bgr color = new Bgr(0,0,0);
            

            for (int i = 0; i < dblImg.Rows; i++){
                for (int j = 0; j < dblImg.Cols; j++)
                {
                    if(i<10 || j<10 || i> dblImg.Rows-10 || j> dblImg.Cols - 10)
                    {
                        a[i, j] = color;
                    }
                }
            }
            a.Mat.ConvertTo(outImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            return outImg.ToImage<Bgr, byte>().ToBitmap();
        }



        private void SharpeningControl_Load(object sender, EventArgs e)
        {
            tbSigma.Value = (int)Math.Round((DEFAULT_RAD - MIN_RAD) * (tbSigma.Maximum - tbSigma.Minimum) /
                (tbSigma.TickFrequency * (MAX_RAD - MIN_RAD)));
            radi = tbSigma.Value * tbSigma.TickFrequency * 
                (MAX_RAD - MIN_RAD) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_RAD; 
            lbSigma.Text = radi.ToString();

            tbAmount.Value = (int)Math.Round((DEFAULT_INTENSITY - MIN_INTENSITY) * (tbAmount.Maximum - tbAmount.Minimum) /
                (tbAmount.TickFrequency * (MAX_INTENSITY - MIN_INTENSITY)));
            intensity = tbAmount.Value * tbAmount.TickFrequency *
               (MAX_INTENSITY - MIN_INTENSITY) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_INTENSITY; 
            lbAmount.Text = intensity.ToString();
        }

        private void tbSigma_Scroll(object sender, EventArgs e)
        {
            radi = tbSigma.Value * tbSigma.TickFrequency *
               (MAX_RAD - MIN_RAD) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_RAD;
            lbSigma.Text = radi.ToString();
        }

        private void tbAmount_Scroll(object sender, EventArgs e)
        {
            intensity = tbAmount.Value * tbAmount.TickFrequency *
               (MAX_INTENSITY - MIN_INTENSITY) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_INTENSITY; 
            lbAmount.Text = intensity.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int radius = (int)radi;
            int intense = (int)intensity;
            if (ApplyClicked != null)
            {
                string[] parameters = {ImageProcessingTypes.Vignette, radius.ToString(), intense.ToString()};
                this.ApplyClicked(this,
                    new ImageProcessingEventArgs(parameters));
            }
                

        }

       
    }

    

}
