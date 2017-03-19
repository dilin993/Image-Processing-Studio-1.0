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
    public partial class Exposure : UserControl
    {
        public event EventHandler button1_Clicked;
        double MAX_AMOUNT = 2;
        double MIN_AMOUNT = -2;
        double EV;

        public Exposure()
        {
            InitializeComponent();
        }

        


        private void Exposure_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            EV = trackBar1.Value * (MAX_AMOUNT - MIN_AMOUNT) / (trackBar1.Maximum - trackBar1.Minimum);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int EV1 = (int)EV;
            if (button1_Clicked != null)
            {
                string[] parameters = {ImageProcessingTypes.ExposureAdjusting,
                EV1.ToString()};
                this.button1_Clicked(this,
                    new ImageProcessingEventArgs(parameters));
            }

        }

        
    }
}
