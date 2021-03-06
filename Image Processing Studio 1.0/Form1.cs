﻿using System;
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
using MetadataExtractor;

namespace Image_Processing_Studio_1._0
{
    public partial class Form1 : Form
    {
        public static UMat img;
        List<ImageHistory> imgList;
        const int CAPACITY = 100;
        int curIndex = -1;
        Image displayImage;

        // controls
        SharpeningControl sharpeningControl;
        NoiseRemovalControl noiseRemovalControl;
        EXIF_view EXIF_details;
        SaturationAdjustment SaturationControl;
        ColorAdjustment ColorControl;
        Vignette vignette;
        ColorTemperatureControl colorTempControl;
        HightlightShadows HighlightShadowsControl;
        Exposure ExposureControl;
        Contrast ContrastControl;

        public Form1()
        {
            InitializeComponent();
            imgList = new List<ImageHistory>(CAPACITY);
            openFileDialog1.Filter = GetImageFilter();
            saveFileDialog1.Filter = openFileDialog1.Filter;

            // initialize user controls
            sharpeningControl = new SharpeningControl
            {
                Dock = DockStyle.Top
            };
            sharpeningControl.ApplyClicked += onProcessingApplyClicked;

            noiseRemovalControl = new NoiseRemovalControl
            {
                Dock = DockStyle.Top
            };
            noiseRemovalControl.ApplyClicked += onProcessingApplyClicked;

            SaturationControl = new SaturationAdjustment
            {
                Dock = DockStyle.Top
            };
            SaturationControl.ApplyClicked += onProcessingApplyClicked;

            ColorControl = new ColorAdjustment
            {
                Dock = DockStyle.Top
            };
            ColorControl.ApplyClicked += onProcessingApplyClicked;

            vignette = new Vignette
            {
                Dock = DockStyle.Top
            };
            vignette.ApplyClicked += onProcessingApplyClicked;

            colorTempControl = new ColorTemperatureControl
            {
                Dock = DockStyle.Top
            };
            colorTempControl.ApplyClicked += onProcessingApplyClicked;

            HighlightShadowsControl = new HightlightShadows
            {
                Dock = DockStyle.Top
            };
            HighlightShadowsControl.ApplyClicked += onProcessingApplyClicked;


            ExposureControl = new Exposure
            {
                Dock = DockStyle.Top
            };
            ExposureControl.button1_Clicked += onProcessingApplyClicked;

            ContrastControl = new Contrast
            {
                Dock = DockStyle.Top
            };
            ContrastControl.button1_Clicked += onProcessingApplyClicked;
        }

        public string GetImageFilter()
        {
            StringBuilder allImageExtensions = new StringBuilder();
            string separator = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            Dictionary<string, string> images = new Dictionary<string, string>();
            foreach (ImageCodecInfo codec in codecs)
            {
                allImageExtensions.Append(separator);
                allImageExtensions.Append(codec.FilenameExtension);
                separator = ";";
                images.Add(string.Format("{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension),
                           codec.FilenameExtension);
            }
            StringBuilder sb = new StringBuilder();
            if (allImageExtensions.Length > 0)
            {
                sb.AppendFormat("{0}|{1}", "All Images", allImageExtensions.ToString());
            }
            images.Add("All Files", "*.*");
            foreach (KeyValuePair<string, string> image in images)
            {
                sb.AppendFormat("|{0}|{1}", image.Key, image.Value);
            }
            return sb.ToString();
        }

        private void redrawImg()
        {
            /// Redraw the image from the mat img
            /// updateDIsplay automatically
            if (img == null) return;
            try
            {
                displayImage = img.ToImage<Bgr, byte>().ToBitmap();

                updateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               foreach(string filename in openFileDialog1.FileNames)
                {
                    imgList.Add(new ImageHistory(filename));
                }
                if (curIndex < 0)
                    changeIndex(0);
                else
                    uiUpdate();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            uiUpdate();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Histograms";
            myPane.XAxis.Title.Text = "Pixel Value";
            myPane.YAxis.Title.Text = "";
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 255;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 2;
            zedGraphControl1.IsAntiAlias = true;
            // Make sure the Graph gets redrawn
            zedGraphControl1.Invalidate();
        }

        private void reloadImage()
        {
            /// reload the img from scratch 
            /// redraw the image automatically
            if (curIndex < 0 || curIndex >= imgList.Count) return;
            try
            {
                if (img != null)
                    img.Dispose();
                img = new UMat(imgList[curIndex].Filename,ImreadModes.Color);
                char[] delimiterChars = { ','};

                foreach (string process in imgList[curIndex].History)
                {
                    img = ImageProcessor.getResult(ref img, process.Split(delimiterChars));
                }
                redrawImg();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeIndex(int index)
        {
            if(index>=0 && index<imgList.Count)
            {
                curIndex = index;
                uiUpdate();
                reloadImage();
            }
        }

        private void updateDisplay()
        {
            /// Update the display of image with proper resizing
            if (displayImage == null) return;

            HistogramUpdate(img.ToImage<Bgr, Byte>());

            if (displayImage.Width<=pictureBox1.Width && displayImage.Height<=pictureBox1.Height)
            {
                pictureBox1.Image = displayImage;
                return;
            }
            double alpha = Math.Atan2(displayImage.Height, displayImage.Width);
            double beta = Math.Atan2(pictureBox1.Height, pictureBox1.Width);
            int width, height;
            if(alpha<beta)
            {
                width = pictureBox1.Width;
                height = (int)Math.Round(width * Math.Tan(alpha));
            }
            else
            {
                height = pictureBox1.Height;
                width = (int)Math.Round(height/ Math.Tan(alpha));
            }
          
            pictureBox1.Image = new Bitmap(displayImage, width, height);
        }
        

        private void uiUpdate()
        {
            if(imgList.Count<=0 || curIndex < 0 || curIndex >= imgList.Count)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnSharpen.Enabled = false;
                operationTab.Enabled = false;
                btnDenoise.Enabled = false;
                EXIF.Enabled = false;
                btnSaturation.Enabled = false;
                btnColorAdjust.Enabled = false;
                btnCrop.Enabled = false;
                btnUndo.Enabled = false;
                btnSave.Enabled = false;
                btnVignette.Enabled = false;
                btnColorTemp.Enabled = false;
                btnCorrection.Enabled = false;
                btnExposure.Enabled = false;
                btnContrast.Enabled = false;
            }
            else
            {
                if (curIndex + 1 < imgList.Count)
                    btnNext.Enabled = true;
                else
                    btnNext.Enabled = false;

                if (curIndex - 1 >= 0)
                    btnPrev.Enabled = true;
                else
                    btnPrev.Enabled = false;

               
                operationTab.Enabled = true;
                btnSharpen.Enabled = true;
                btnDenoise.Enabled = true;
                EXIF.Enabled = true;
                btnSaturation.Enabled = true;
                btnColorAdjust.Enabled = true;
                btnCrop.Enabled = true;
                btnSave.Enabled = true;
                btnVignette.Enabled = true;
                btnColorTemp.Enabled = true;
                btnCorrection.Enabled = true;
                btnExposure.Enabled = true;
                btnContrast.Enabled = true;
                if (imgList[curIndex].History.Count > 0)
                    btnUndo.Enabled = true;
                else
                    btnUndo.Enabled = false;
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changeIndex(curIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            changeIndex(curIndex - 1);
        }

        private void form1_resized(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(sharpeningControl);
        }

        private void onProcessingApplyClicked(object sender, EventArgs e)
        {
            try
            {
                ImageProcessingEventArgs ei = (ImageProcessingEventArgs)e;
                img = ImageProcessor.getResult(ref img, ei.Parameters);
                HistogramUpdate(img.ToImage<Bgr, Byte>());
                redrawImg();
                imgList[curIndex].History.Push(ei.ToString());
                uiUpdate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnDenoise_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(noiseRemovalControl);

        }

        private void HistogramUpdate(Image<Bgr, Byte> img_ref)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            Image<Gray, byte> gray_image = img_ref.Convert<Gray, byte>();

            DenseHistogram Hist = new DenseHistogram(256, new RangeF(0, 255));

            double[] m_gray = new double[256];
            Hist.Calculate(new Image<Gray, byte>[] { gray_image }, false, null);
            Hist.CopyTo(m_gray);
            double gray_max = m_gray.Max();

            double[] m_red = new double[256];
            Hist.Calculate(new Image<Gray, byte>[] { img_ref[2] }, false, null);
            Hist.CopyTo(m_red);
            double red_max = m_red.Max();

            double[] m_green = new double[256];
            Hist.Calculate(new Image<Gray, byte>[] { img_ref[1] }, false, null);
            Hist.CopyTo(m_green);
            double green_max = m_green.Max();

            double[] m_blue = new double[256];
            Hist.Calculate(new Image<Gray, byte>[] { img_ref[0] }, false, null);
            Hist.CopyTo(m_blue);
            double blue_max = m_blue.Max();

            double[] index = new double[256];
            for (int i = 0; i < 256; i++)
            {
                index[i] = i;
                m_red[i] /= red_max;
                m_green[i] /= green_max;
                m_blue[i] /= blue_max;
                m_gray[i] /= gray_max;
            }

            myPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("gray", index, m_gray, Color.Black, SymbolType.None);
            myCurve = myPane.AddCurve("red", index, m_red, Color.Red, SymbolType.None);
            myCurve = myPane.AddCurve("green", index, m_green, Color.Green, SymbolType.None);
            myCurve = myPane.AddCurve("blue", index, m_blue, Color.Blue, SymbolType.None);
            zedGraphControl1.Invalidate();

        }

        private void EXIF_Click(object sender, EventArgs e)
        {
            EXIF_details = new EXIF_view();
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(imgList[curIndex].Filename);
                String str;
                EXIF_details.clearText();
                foreach (var directory in directories)
                {

                    foreach (var tag in directory.Tags)
                    {
                        str = $"[{directory.Name}] {tag.Name} = {tag.Description}";
                        //Console.WriteLine(str);
                        EXIF_details.Show();
                        EXIF_details.updateDetails(str);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSaturation_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(SaturationControl);
        }

        private void btnColorAdjust_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(ColorControl);
         }
         
         private void btnCrop_Click(object sender, EventArgs e)
        {
            var frm = new Form2
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.ApplyClicked += onProcessingApplyClicked;
            frm.ShowDialog();
         }


        private void VignetteButton_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(vignette);
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                imgList[curIndex].History.Pop();
                uiUpdate();
                reloadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnColorTemp_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(colorTempControl);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    CvInvoke.Imwrite(saveFileDialog1.FileName, img);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnCorrection_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(HighlightShadowsControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(ExposureControl);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operationTab.Panel2.Controls.Clear();
            operationTab.Panel2.Controls.Add(ContrastControl);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AboutBox1 abtBox = new AboutBox1();
            abtBox.ShowDialog();
        }
    }
}
