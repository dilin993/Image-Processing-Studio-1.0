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
    public partial class SaturationAdjustment : UserControl
    {
        double amount;
        double previous_amount=0.0;
        public event EventHandler ApplyClicked;
        double MIN_AMOUNT = -1.0;
        double MAX_AMOUNT = 1.0;
        double DEFAULT_AMOUNT = 0;


        public SaturationAdjustment()
        {
            InitializeComponent();
        }

        public Image getSaturationChanged(Mat img)
        {
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            UMat outImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            double shift = ((amount!=previous_amount)&&(1+ amount - previous_amount>0))? amount - previous_amount : 0;
            CvInvoke.AddWeighted(dblImg, 1 + shift, dblImg, 0, 0, outImg);
            dblImg.Dispose();
            img.Dispose();
            previous_amount = amount;
            return outImg.ToImage<Bgr, byte>().ToBitmap();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyClicked != null)
            {
                string[] parameters = {ImageProcessingTypes.SaturationAdjusting,
                amount.ToString()};
                this.ApplyClicked(this,
                    new ImageProcessingEventArgs(parameters));
            }
        }

        private void SaturationLevel_Scroll(object sender, EventArgs e)
        {
            amount = SaturationLevel.Value * SaturationLevel.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (SaturationLevel.Maximum - SaturationLevel.Minimum);
            SaturationValue.Text = amount.ToString();
           
        }

        private void SaturationAdjustment_Load(object sender, EventArgs e)
        {
            SaturationLevel.Value = (int)Math.Round((DEFAULT_AMOUNT - MIN_AMOUNT) * (SaturationLevel.Maximum - SaturationLevel.Minimum) /
                (SaturationLevel.TickFrequency * (MAX_AMOUNT - MIN_AMOUNT)));
        }
    }
}
