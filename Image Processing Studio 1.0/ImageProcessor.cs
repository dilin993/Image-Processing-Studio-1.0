using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Emgu.CV.CvEnum;


namespace Image_Processing_Studio_1._0
{
    static class ImageProcessingTypes
    {
        public const string Sharpening = "sharpening";
        public const string GaussianFiltering = "gaussian filtering";
        public const string MedianFiltering = "median filtering";
        public const string N1MeansDenoising = "n1 means denoising";
        public const string SaturationAdjusting = "saturation adjustment";
        public const string ColorAdjusting = "color adjustment";
        public const string Vignette = "vignette";
        public const string Cropping = "cropping";
        public const string ColorTemperatureAdjusting = "color temperature adjusting";
        public const string ExposureAdjusting = "exposure adjusting";
        public const string ContrastAdjusting = "contrast adjusting";

    }

    class ImageProcessor
    {
        public static UMat getSharpened(UMat img, double sigma, double amount)
        {
            /// <summary>
            /// Apply sharpening to the given UMat.
            /// </summary>
            /// <param name="img">The src UMat.</param>
            /// <param name="sigma">Sigma value for shrpening.</param>
            /// <param name="amount">Amount of sharpening required.</param>
            /// <returns>
            /// Sharpened UMat image.
            /// </returns>
            /// <remarks>
            /// Used for image sharpening.
            /// </remarks>
            /// 

            
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            UMat dblBlurImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            UMat outImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            int k = 2 * (int)Math.Round(3.0 * sigma) + 1;
            CvInvoke.GaussianBlur(dblImg, dblBlurImg, new Size(k, k), sigma, sigma);
            CvInvoke.AddWeighted(dblImg, 1.0 + amount, dblBlurImg, -amount, 0, outImg);
            dblImg.Dispose();
            dblBlurImg.Dispose();
            img.Dispose();
            return outImg;
        }

        public static UMat getGaussianFiltered(ref UMat img, double sigma, int k)
        {
            /// <summary>
            /// Apply Gaussian filtering to the given UMat.
            /// </summary>
            /// <param name="img">The src UMat.</param>
            /// <param name="sigma">Sigma value for filtering.</param>
            /// <param name="k">Kernel size required.</param>
            /// <returns>
            /// Filtered UMat image.
            /// </returns>
            /// <remarks>
            /// Used for image filtering using gaussian kernel.
            /// </remarks>

            UMat outImg = new UMat(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
            CvInvoke.GaussianBlur(img, outImg, new Size(k, k), sigma, sigma);
            img.Dispose();
            return outImg;
        }

        public static UMat getMedianFiltered(ref UMat img, int k)
        {
            /// <summary>
            /// Apply Median filtering to the given UMat.
            /// </summary>
            /// <param name="img">The src UMat.</param>
            /// <param name="k">Kernel size required.</param>
            /// <returns>
            /// Filtered UMat image.
            /// </returns>
            /// <remarks>
            /// Used for image filtering using median filtering.
            /// </remarks>

            UMat outImg = new UMat(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
            CvInvoke.MedianBlur(img,outImg,k);
            img.Dispose();
            return outImg;
        }

        public static UMat getN1MeanFiltered(ref UMat img, float h, float hcolor)
        {
            /// <summary>
            /// Apply N1 Mean filtering to the given UMat.
            /// </summary>
            /// <param name="img">The src UMat.</param>
            /// <param name="h">Strength parameter.</param>
            /// <param name="hcolor">Color strength parameter.</param>
            /// <returns>
            /// Filtered UMat image.
            /// </returns>
            /// <remarks>
            /// Used for image filtering using N1 mean filtering.
            /// </remarks>
            UMat tmp = new UMat();
            img.ConvertTo(tmp, DepthType.Cv8U);
            UMat outImg = new UMat(tmp.Rows, tmp.Cols, tmp.Depth, tmp.NumberOfChannels);
            CvInvoke.FastNlMeansDenoisingColored(tmp, outImg, h, hcolor);
            img.Dispose();
            tmp.Dispose();
            return outImg;
        }

        public static UMat getSaturationAdjusted(ref UMat img,double amount)
        {
            Image<Hsv, double> outImg = img.ToImage<Hsv, double>();
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            outImg = img.ToImage<Hsv, double>();
            var colors = new VectorOfUMat(3);
            CvInvoke.Split(outImg, colors);
            double shift = (1+amount) >= 0.0 ? 1+amount : 0;
            CvInvoke.AddWeighted(colors[0], shift, colors[0], 0,0, colors[0]);
            CvInvoke.AddWeighted(colors[1], shift, colors[1], 0, 0, colors[1]);
            CvInvoke.AddWeighted(colors[2], shift, colors[2], 0, 0, colors[2]);
            CvInvoke.Merge(colors, dblImg);
            return dblImg;
            
        }

        public static void ColorTemperatureToRGB(int kelvin, out int r, out int g, out int b)
        {
            int temp = kelvin / 100;
            if (temp <= 65)
            {
                r = 255;
                g = temp;
                g = (int)Math.Round(99.4708025861 * Math.Log(g) - 161.1195681661);

                if (temp <= 19)
                {
                    b = 0;
                }
                else
                {
                    b = temp - 10;
                    b = (int)Math.Round(138.5177312231 * Math.Log(b) - 305.0447927307);
                }
            }
            else
            {
                r = temp - 60;
                r = (int)Math.Round(329.698727446 * Math.Pow(r, -0.1332047592));

                g = temp - 60;
                g = (int)Math.Round(288.1221695283 * Math.Pow(g, -0.0755148492));

                b = 255;
            }

            r = clamp(r, 0, 255);
            g = clamp(g, 0, 255);
            b = clamp(b, 0, 255);
        }



        public static int clamp(int x, int min, int max)
        {



            if (x < min) { return min; }

            if (x > max) { return max; }



            return x;
        }

        public static UMat getColorTemperatureAdjusted(ref UMat img, int r, int g, int b)
        {
            float[] data = {(float)b/255.0f,0f,0f,
                            0f,(float)g/255.0f,0f,
                            0f,0f,(float)r/255.0f};
            Mat colMat = new Mat(new Size(3, 3), DepthType.Cv32F, 1);

            Marshal.Copy(data, 0, colMat.DataPointer, 9);
            //UMat reshaped = srcMat.Reshape(1, srcImg.Cols * srcImg.Rows);
            UMat outMat = new UMat();
            CvInvoke.Transform(img, outMat, colMat);
            outMat = outMat.Reshape(3, img.Rows);
            img.Dispose();
            colMat.Dispose();
            return outMat;
        }

        public static UMat getVignetteAdjusted(ref UMat img, int radi, int intensity)
        {
            Mat dblImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            Mat outImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            img.ConvertTo(outImg, Emgu.CV.CvEnum.DepthType.Cv64F);

            Image<Bgr, Byte> a = outImg.ToImage<Bgr, Byte>();
            Bgr CurrentColor = new Bgr(0, 0, 0);

            for (int i = 0; i < dblImg.Rows; i++)
            {
                for (int j = 0; j < dblImg.Cols; j++)
                {
                    if (i < radi)
                    {
                        CurrentColor = a[i, j];
                        double red = CurrentColor.Red;
                        double green = CurrentColor.Green;
                        double blue = CurrentColor.Blue;
                        double newred = red - (double)intensity * (double)radi + (double)intensity * (double)i;
                        double newgreen = green - (double)intensity * (double)radi + (double)intensity * (double)i;
                        double newblue = blue - (double)intensity * (double)radi + (double)intensity * (double)i;
                        Bgr SetColor = new Bgr(newblue, newgreen, newred);
                        a[i, j] = SetColor;
                    }
                    if ( j < radi)
                    {
                        CurrentColor = a[i, j];
                        double red = CurrentColor.Red;
                        double green = CurrentColor.Green;
                        double blue = CurrentColor.Blue;
                        double newred = red - (double)intensity * (double)radi + (double)intensity * (double)j;
                        double newgreen = green - (double)intensity * (double)radi + (double)intensity * (double)j;
                        double newblue = blue - (double)intensity * (double)radi + (double)intensity * (double)j;
                        Bgr SetColor = new Bgr(newblue, newgreen, newred);
                        a[i, j] = SetColor;
                    }

                    if ( i > dblImg.Rows - radi )
                    {
                        CurrentColor = a[i, j];
                        double red = CurrentColor.Red;
                        double green = CurrentColor.Green;
                        double blue = CurrentColor.Blue;
                        double newred = red - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Rows - (double)intensity * (double)i;
                        double newgreen = green - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Rows - (double)intensity * (double)i;
                        double newblue = blue - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Rows - (double)intensity * (double)i;
                        Bgr SetColor = new Bgr(newblue, newgreen, newred);
                        a[i, j] = SetColor;
                    }

                    if ( j > dblImg.Cols - radi)
                    {
                        CurrentColor = a[i, j];
                        double red = CurrentColor.Red;
                        double green = CurrentColor.Green;
                        double blue = CurrentColor.Blue;
                        double newred = red - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Cols - (double)intensity * (double)j;
                        double newgreen = green - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Cols - (double)intensity * (double)j;
                        double newblue = blue - (double)intensity * (double)radi + (double)intensity * (double)dblImg.Cols - (double)intensity * (double)j;
                        Bgr SetColor = new Bgr(newblue, newgreen, newred);
                        a[i, j] = SetColor;
                    }
                }
            }

            return a.ToUMat();
        }

        public static UMat getColorAdjusted(ref UMat img,double redshift,double greenshift,double blueshift)
        {
            double shift;
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            var colors = new VectorOfUMat(3);
            CvInvoke.Split(img, colors);
            shift = (1 + redshift) > 0 ? (1 + redshift) : 0;
            CvInvoke.AddWeighted(colors[2],shift, colors[2],0,0,colors[2]);
            shift = (1 + greenshift) > 0 ? (1 + greenshift) : 0;
            CvInvoke.AddWeighted(colors[1], shift, colors[1], 0, 0, colors[1]);
            shift = (1 + blueshift) > 0 ? (1 + blueshift) : 0;
            CvInvoke.AddWeighted(colors[0], shift, colors[0], 0, 0, colors[0]);
            CvInvoke.Merge(colors, dblImg);
            return dblImg;


        }

        public static UMat getCropped(ref UMat img, int x, int y,int width, int height)
        {
            UMat outImg = new UMat(img, new Rectangle(x, y, width, height));
            img.Dispose();
            return outImg;
        }


        public static UMat getExposureCorrected(ref UMat img, double ev)
        {
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            UMat outImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            //outImg = (UMat)ev*dblImg;
            CvInvoke.AddWeighted(dblImg, ev, dblImg, 0, 0, outImg);
            //CvInvoke.cvConvertScale(dblImg, outImg, ev,0);
            dblImg.Dispose();
            img.Dispose();
            return outImg;
        }

        public static UMat getContrastAdjusted(ref UMat img, double cont1, double cont2)
        {
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            UMat outImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            //outImg = (UMat)ev*dblImg;
            CvInvoke.AddWeighted(dblImg, cont1, dblImg, 0, cont1*(-128)+cont2+128, outImg);
            //CvInvoke.cvConvertScale(dblImg, outImg, ev,0);
            dblImg.Dispose();
            img.Dispose();
            return outImg;
        }


        public static UMat getResult(ref UMat img, string[] parameters)
        {
            /// <summary>
            /// Apply image processing operation to the given UMat.
            /// </summary>
            /// <param name="img">The src UMat.</param>
            /// <param name="parameters">Define parameters of the operation.</param>
            /// <returns>
            /// Processed UMat image.
            /// </returns>
            /// <remarks>
            /// Used for image processing.
            /// </remarks>
            /// 
            if(CvInvoke.HaveOpenCL && CvInvoke.HaveOpenCLCompatibleGpuDevice)
            {
                CvInvoke.UseOpenCL = true;
                CvInvoke.UseOptimized = true;
                //MessageBox.Show("OpenCL is enabled.");
            }
           
            switch (parameters[0].ToLower())
            {
                case ImageProcessingTypes.Sharpening:
                    return getSharpened(img, double.Parse(parameters[1]), double.Parse(parameters[2]));

                case ImageProcessingTypes.GaussianFiltering:
                    return getGaussianFiltered(ref img, double.Parse(parameters[1]), int.Parse(parameters[2]));

                case ImageProcessingTypes.MedianFiltering:
                    return getMedianFiltered(ref img, int.Parse(parameters[1]));

                case ImageProcessingTypes.N1MeansDenoising:
                    return getN1MeanFiltered(ref img, float.Parse(parameters[1]), float.Parse(parameters[2]));

                case ImageProcessingTypes.SaturationAdjusting:
                    return getSaturationAdjusted(ref img, double.Parse(parameters[1]));

                case ImageProcessingTypes.Vignette:
                    return getVignetteAdjusted(ref img, int.Parse(parameters[1]), int.Parse(parameters[2]));

                case ImageProcessingTypes.ColorAdjusting:
                    return getColorAdjusted(ref img, double.Parse(parameters[1]), 
                        double.Parse(parameters[2]), double.Parse(parameters[3]));

                case ImageProcessingTypes.Cropping:
                    return getCropped(ref img, int.Parse(parameters[1]), int.Parse(parameters[2]),
                        int.Parse(parameters[3]), int.Parse(parameters[4]));

                case ImageProcessingTypes.ColorTemperatureAdjusting:
                    return getColorTemperatureAdjusted(ref img, int.Parse(parameters[1]),
                        int.Parse(parameters[2]), int.Parse(parameters[3]));

                case ImageProcessingTypes.ExposureAdjusting:
                    return getExposureCorrected(ref img, double.Parse(parameters[1]));

                case ImageProcessingTypes.ContrastAdjusting:
                    return getContrastAdjusted(ref img, double.Parse(parameters[1]), double.Parse(parameters[2]));
                default:
                    return img;
            }
        }
    }
}
