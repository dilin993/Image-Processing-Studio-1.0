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
    public partial class ColorAdjustment : UserControl
    {
        public event EventHandler ApplyClicked;
        double RedChange, GreenChange, BlueChange;
        double MAX_AMOUNT = 255.0;
        double MIN_AMOUNT = 0.0;

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            GreenChange = GreenBar.Value * GreenBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            BlueChange = BlueBar.Value * BlueBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);
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

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            RedChange = RedBar.Value * RedBar.TickFrequency *
               (MAX_AMOUNT - MIN_AMOUNT) / (RedBar.Maximum - RedBar.Minimum);
        }

        public ColorAdjustment()
        {
            InitializeComponent();
        }



        
    }
}
