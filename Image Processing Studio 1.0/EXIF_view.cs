using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Studio_1._0
{
    public partial class EXIF_view : Form
    {
        public EXIF_view()
        {
            InitializeComponent();
        }

        public void updateDetails(String str)
        {
            richTextBox1.AppendText(str+"\n");
        }

        public void clearText()
        {
            richTextBox1.Clear();
        }
    }
}
