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
    public partial class ColorTemperatureControl : UserControl
    {
        private int temp;
        private int r, g, b;
        public event EventHandler ApplyClicked;

        public ColorTemperatureControl()
        {
            InitializeComponent();
        }

        private void tbTemp_Scroll(object sender, EventArgs e)
        {
            tempChanged();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string[] parameters = {ImageProcessingTypes.ColorTemperatureAdjusting,
                                    r.ToString(),
                                    g.ToString(),
                                    b.ToString()};
            this.ApplyClicked(this, new ImageProcessingEventArgs(parameters));
        }

        private void tempChanged()
        {
            temp = tbTemp.Value;
            ImageProcessor.ColorTemperatureToRGB(temp, out r, out g, out b);
            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private void ColorTemperatureControl_Load(object sender, EventArgs e)
        {
            tempChanged();
        }
    }
}
