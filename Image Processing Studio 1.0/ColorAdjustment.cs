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
    public partial class ColorAdjustment : UserControl
    {
        public event EventHandler ApplyClicked;
        double RedChange, GreenChange, BlueChange;
        double MAX_AMOUNT = 1;
        double MIN_AMOUNT = -1;
        

        public Image getColorAdjusted(Mat img,double redshift,double greenshift,double blueshift)
        {
            Image<Bgr, Byte> outImg = img.ToImage<Bgr, byte>();
            //double shift = ((amount != previous_amount) && (1 + amount - previous_amount > 0)) ? amount - previous_amount : 0;

            return outImg.ToBitmap();
        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            RedChange = RedBar.Value * RedBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);

            RedShiftVal.Text = RedChange.ToString();
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            GreenChange = GreenBar.Value * GreenBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);

            GreenShiftVal.Text = GreenChange.ToString();
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            BlueChange = BlueBar.Value * BlueBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);
            BlueShiftVal.Text = BlueChange.ToString();
        }

        private void ColorAdjustment_Load(object sender, EventArgs e)
        {

            RedChange = 0.0;
            GreenChange = 0.0;
            BlueChange = 0.0;
            RedBar.Value = 0;
            GreenBar.Value = 0;
            BlueBar.Value = 0;

        }

        

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyClicked != null)
            {
                string[] parameters = {ImageProcessingTypes.ColorAdjusting,
                RedChange.ToString(),GreenChange.ToString(),BlueChange.ToString()};
                this.ApplyClicked(this,
                    new ImageProcessingEventArgs(parameters));
            }
        }

        

        public ColorAdjustment()
        {
            InitializeComponent();
        }



        
    }
}
