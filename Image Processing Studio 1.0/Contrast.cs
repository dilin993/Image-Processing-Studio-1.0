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
    public partial class Contrast : UserControl
    {
        public event EventHandler button1_Clicked;
        double MAX_AMOUNT = 50;
        double MIN_AMOUNT = -50;
        double cont1;
        double cont2;
        public Contrast()
        {
            InitializeComponent();
        }

        private void Contrast_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            cont1 = trackBar1.Value * (MAX_AMOUNT - MIN_AMOUNT) / (trackBar1.Maximum - trackBar1.Minimum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double contrast1 = 1.2;
            double contrast2 = cont1;
            if (button1_Clicked != null)
            {
                string[] parameters = {ImageProcessingTypes.ContrastAdjusting,
                contrast1.ToString(), contrast2.ToString()};
                this.button1_Clicked(this,
                    new ImageProcessingEventArgs(parameters));
            }

        }

        
    }
}
