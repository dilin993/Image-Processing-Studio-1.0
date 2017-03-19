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
    public partial class HightlightShadows : UserControl
    {
        public event EventHandler ApplyClicked;
        double gamma;
        double shadowlevel;
        double highlightlevel;

        double Gamma_MAX = 1.3;
        double Gamma_MIN = .7;

        double Shadow_MAX = 1.3;
        double Shadow_MIN = .7;
        //int Shadow_upperLimit = 100;

        double Highlight_MAX = 1.8;
        double Highlight_MIN = .2;
        //int Highlight_lowerLimit = 150;

        public HightlightShadows()
        {
            InitializeComponent();
        }

        private void GammaBar_Scroll(object sender, EventArgs e)
        {
            gamma = GammaBar.Value * GammaBar.TickFrequency * (Gamma_MAX - Gamma_MIN) / (GammaBar.Maximum - GammaBar.Minimum) + Gamma_MIN;
            GammaVal.Text = gamma.ToString();
            shadowlevel = 1.0;
            ShadowBar.Value = 50;
            highlightlevel = 1.0;
            HighlightBar.Value = 50;
            ShadowVal.Text = shadowlevel.ToString();
            HighlightVal.Text = highlightlevel.ToString();
        }

        private void HighlightBar_Scroll(object sender, EventArgs e)
        {
            highlightlevel = HighlightBar.Value * HighlightBar.TickFrequency * (Highlight_MAX - Highlight_MIN) / (HighlightBar.Maximum - HighlightBar.Minimum) + Highlight_MIN;
            HighlightVal.Text = highlightlevel.ToString();
            gamma = 1.0;
            shadowlevel = 1.0;
            GammaBar.Value = 50;
            ShadowBar.Value = 50;
            ShadowVal.Text = shadowlevel.ToString();
            GammaVal.Text = gamma.ToString();
        }

        private void ShadowBar_Scroll(object sender, EventArgs e)
        {
            shadowlevel = ShadowBar.Value * ShadowBar.TickFrequency * (Shadow_MAX - Shadow_MIN) / (ShadowBar.Maximum - ShadowBar.Minimum) + Shadow_MIN;
            ShadowVal.Text = shadowlevel.ToString();
            gamma = 1.0;
            highlightlevel = 1.0;
            GammaBar.Value = 50;
            HighlightBar.Value = 50;
            GammaVal.Text = gamma.ToString();
            HighlightVal.Text = highlightlevel.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyClicked != null)
            {
                string[] parameters = {ImageProcessingTypes.HighlightShadowAdjusting,
                GammaVal.Text,HighlightVal.Text,ShadowVal.Text};
                
                this.ApplyClicked(this,
                    new ImageProcessingEventArgs(parameters));
            }
        }

        private void HightlightShadows_Load(object sender, EventArgs e)
        {
            gamma = 1.0;
            highlightlevel = 1.0;
            shadowlevel = 1.0;
            GammaVal.Text = gamma.ToString();
            HighlightVal.Text = highlightlevel.ToString();
            ShadowVal.Text = shadowlevel.ToString();
        }

        
    }
}
