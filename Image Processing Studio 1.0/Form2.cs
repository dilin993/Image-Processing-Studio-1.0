using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using ZedGraph;

namespace Image_Processing_Studio_1._0
{
    public partial class Form2 : Form
    {
        UMat img;
        Image<Bgr, byte> displayImage;

        public Form2()
        {
            InitializeComponent();
            img = Form1.img_crop;
            redrawImg();
        }

        private void updateDisplay()
        {
            /// Update the display of image with proper resizing
            if (displayImage == null) return;

            if (displayImage.Width <= pictureBox1.Width && displayImage.Height <= pictureBox1.Height)
            {
                pictureBox1.Image = displayImage;
                return;
            }
            double alpha = Math.Atan2(displayImage.Height, displayImage.Width);
            double beta = Math.Atan2(pictureBox1.Height, pictureBox1.Width);
            int width, height;
            if (alpha < beta)
            {
                width = pictureBox1.Width;
                height = (int)Math.Round(width * Math.Tan(alpha));
            }
            else
            {
                height = pictureBox1.Height;
                width = (int)Math.Round(height / Math.Tan(alpha));
            }

            pictureBox1.Image = displayImage;
        }

        private void redrawImg()
        {
            /// Redraw the image from the mat img
            /// updateDIsplay automatically
            if (img == null) return;
            try
            {
                displayImage = new Image<Bgr, byte>(img.ToImage<Bgr, byte>().ToBitmap());//img.ToImage<Bgr, byte>().ToBitmap();

                updateDisplay();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\       
        public static void ConvertCoordinates(PictureBox pic,out int X0, out int Y0, int x, int y)
        {
            int pic_hgt = pic.ClientSize.Height;
            int pic_wid = pic.ClientSize.Width;
            int img_hgt = pic.Image.Height;
            int img_wid = pic.Image.Width;

            X0 = x;
            Y0 = y;
            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    X0 = x - (pic_wid - img_wid) / 2;
                    Y0 = y - (pic_hgt - img_hgt) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    X0 = (int)(img_wid * x / (float)pic_wid);
                    Y0 = (int)(img_hgt * y / (float)pic_hgt);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = pic_wid / (float)pic_hgt;
                    float img_aspect = img_wid / (float)img_wid;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        Y0 = (int)(img_hgt * y / (float)pic_hgt);

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        float scaled_width = img_wid * pic_hgt / img_hgt;
                        float dx = (pic_wid - scaled_width) / 2;
                        X0 = (int)((x - dx) * img_hgt / (float)pic_hgt);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        X0 = (int)(img_wid * x / (float)pic_wid);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaled_height = img_hgt * pic_wid / img_wid;
                        float dy = (pic_hgt - scaled_height) / 2;
                        Y0 = (int)((y - dy) * img_wid / pic_wid);
                    }
                    break;
            }  
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #region EVENTOS PICTURE BOX | DEFINIÇÃO DE ROI
        private Image<Bgr, byte> imgEntrada;
        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Rectangle RealImageRect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 64, 64, 64));
        private int thickness = 3;



        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }


        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            #region SETS COORDINATES AT INPUT IMAGE BOX
            int X0, Y0;
            ConvertCoordinates(pictureBox1, out X0, out Y0, e.X, e.Y);
            //labelPostionXY.Text = "Last Position: X:" + X0 + "  Y:" + Y0;

            //Coordinates at input picture box
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            #endregion

            #region SETS COORDINATES AT REAL IMAGE
            //Coordinates at real image - Create ROI
            ConvertCoordinates(pictureBox1, out X0, out Y0,
            RectStartPoint.X, RectStartPoint.Y);
            int X1, Y1;
            ConvertCoordinates(pictureBox1, out X1, out Y1, tempEndPoint.X, tempEndPoint.Y);
            RealImageRect.Location = new Point(
                Math.Min(X0, X1),
                Math.Min(Y0, Y1));
            RealImageRect.Size = new Size(
                Math.Abs(X0 - X1),
                Math.Abs(Y0 - Y1));

           
            imgEntrada = new Image<Bgr, byte>(img.ToImage<Bgr, byte>().ToBitmap());
            imgEntrada.Draw(RealImageRect, new Bgr(Color.Red), thickness);
            imageBoxOutputROI.Image = imgEntrada;
            #endregion

            ((PictureBox)sender).Invalidate();
        }


        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw the rectangle...
            if (pictureBox1.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    //Seleciona a ROI
                    e.Graphics.SetClip(Rect, System.Drawing.Drawing2D.CombineMode.Exclude);
                    e.Graphics.FillRectangle(selectionBrush, new Rectangle
            (0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
                    //e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //Define ROI. Valida altura e largura para evitar index range exception.
            if (RealImageRect.Width > 0 && RealImageRect.Height > 0)
            {
                imgEntrada.ROI = RealImageRect;
                imageBoxROI.Image = imgEntrada;
            }

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Rect = new Rectangle();
            ((PictureBox)sender).Invalidate();
        }

        #endregion

        
    }
}
