using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Studio_1._0
{
    public partial class NoiseRemovalControl : UserControl
    {
        private const double MIN_SIGMA = 0.0;
        private const double MAX_SIGMA = 5.0;
        private const double DEFAULT_SIGMA = 3.0;
        private const float MIN_H = 0.0f;
        private const float MAX_H = 10.0f;
        private const float MIN_HCOLOR = 0.0f;
        private const float MAX_HCOLOR = 10.0f;
        private const float DEFAULT_H = 3.0f;
        private const float DEFAULT_HCOLOR = 3.0f;
        private int kMedian;
        private int kSize;
        double sigma;
        float h;
        float hcolor;
        public event EventHandler ApplyClicked;

        public NoiseRemovalControl()
        {
            InitializeComponent();
        }

        private void NoiseRemovalControl_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            uiUpdate();
        }

        private void uiUpdate()
        {
            if(comboBox1.SelectedIndex==0)
            {
                tbSigma.Minimum = 0;
                tbSigma.Maximum = 500;
                tbAmount.Visible = true;
                lbAmount.Visible = true;
                lbAmountTitle.Visible = true;
                lbSigmaTitle.Text = "sigma = ";
                lbAmountTitle.Text = "ksize = ";
                tbAmount.Minimum = 0;
                tbAmount.Maximum = 16;
                tbSigma.Value = (int)Math.Round((DEFAULT_SIGMA - MIN_SIGMA) * (tbSigma.Maximum - tbSigma.Minimum) /
               (tbSigma.TickFrequency * (MAX_SIGMA - MIN_SIGMA)));
                sigma = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_SIGMA - MIN_SIGMA) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_SIGMA; ;
                lbSigma.Text = sigma.ToString();

                kSize = 2 * (int)Math.Round(3.0*sigma) + 1;
                tbAmount.Value = (kSize-1)/2;
                lbAmount.Text = kSize.ToString();
            }
            else if(comboBox1.SelectedIndex==1)
            {
                tbAmount.Visible = false;
                lbAmount.Visible = false;
                lbAmountTitle.Visible = false;
                lbSigmaTitle.Text = "amount = ";
                tbSigma.Minimum = 0;
                tbSigma.Maximum = 10;
                kMedian = 2 * tbSigma.Value + 1;
                lbSigma.Text = kMedian.ToString();
            }
            else if(comboBox1.SelectedIndex==2)
            {
                tbSigma.Minimum = 0;
                tbSigma.Maximum = 500;
                tbAmount.Visible = true;
                lbAmount.Visible = true;
                lbAmountTitle.Visible = true;
                lbSigmaTitle.Text = "h = ";
                lbAmountTitle.Text = "hcolor = ";
                tbAmount.Minimum = 0;
                tbAmount.Maximum = 100;

                tbSigma.Value = (int)Math.Round((DEFAULT_H - MIN_H) * (tbSigma.Maximum - tbSigma.Minimum) /
              (tbSigma.TickFrequency * (MAX_H - MIN_H)));
                h = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_H - MIN_H) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_H; 
                lbSigma.Text = h.ToString();

                tbAmount.Value = (int)Math.Round((DEFAULT_HCOLOR - MIN_HCOLOR) * (tbAmount.Maximum - tbAmount.Minimum) /
                    (tbAmount.TickFrequency * (MAX_HCOLOR - MIN_HCOLOR)));
                hcolor = tbAmount.Value * tbAmount.TickFrequency *
                   (MAX_HCOLOR - MIN_HCOLOR) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_HCOLOR;
                lbAmount.Text = hcolor.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiUpdate();
        }

        private void tbSigma_Scroll(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                sigma = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_SIGMA - MIN_SIGMA) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_SIGMA; ;
                lbSigma.Text = sigma.ToString();

                
                kSize = 2 * (int)Math.Round(3.0 * sigma) + 1;
                tbAmount.Value = (kSize - 1) / 2;
                lbAmount.Text = kSize.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                kMedian = 2 * tbSigma.Value + 1;
                lbSigma.Text = kMedian.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
                h = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_H - MIN_H) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_H;
                lbSigma.Text = h.ToString();

                hcolor = tbAmount.Value * tbAmount.TickFrequency *
                   (MAX_HCOLOR - MIN_HCOLOR) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_HCOLOR;
                lbAmount.Text = hcolor.ToString();
            }
        }

        private void tbAmount_Scroll(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                sigma = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_SIGMA - MIN_SIGMA) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_SIGMA; ;
                lbSigma.Text = sigma.ToString();

                kSize = 2 * tbAmount.Value + 1;
                lbAmount.Text = kSize.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                kMedian = 2 * tbSigma.Value + 1;
                lbSigma.Text = kMedian.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                h = tbSigma.Value * tbSigma.TickFrequency *
                    (MAX_H - MIN_H) / (tbSigma.Maximum - tbSigma.Minimum) + MIN_H;
                lbSigma.Text = h.ToString();

                hcolor = tbAmount.Value * tbAmount.TickFrequency *
                   (MAX_HCOLOR - MIN_HCOLOR) / (tbAmount.Maximum - tbAmount.Minimum) + MIN_HCOLOR;
                lbAmount.Text = hcolor.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string[] parameters=null;
            if (comboBox1.SelectedIndex == 0)
            {
                string[] p = { comboBox1.Text.ToLower(), sigma.ToString(), kSize.ToString()};
                parameters = p;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string[] p = { comboBox1.Text.ToLower(), kMedian.ToString() };
                parameters = p;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string[] p = { comboBox1.Text.ToLower(),h.ToString(), hcolor.ToString()};
                parameters = p;
            }

            this.ApplyClicked(this,
                   new ImageProcessingEventArgs(parameters));

        }

        private void lbSigma_Click(object sender, EventArgs e)
        {

        }
    }
}
