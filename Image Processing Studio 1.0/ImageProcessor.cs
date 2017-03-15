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

            UMat outImg = new UMat(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
            CvInvoke.FastNlMeansDenoisingColored(img, outImg, h, hcolor);
            img.Dispose();
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
            CvInvoke.AddWeighted(colors[1], shift, colors[1], 0,0, colors[1]);            
            CvInvoke.Merge(colors, dblImg);
            return dblImg;
            
        }

        public static UMat getColorAdjusted(ref UMat img,double redshift,double greenshift,double blueshift)
        {
            double shift;
            UMat dblImg = new UMat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            var colors = new VectorOfUMat(3);
            CvInvoke.Split(img, colors);
            shift = (1 + redshift) > 0 ? (1 + redshift) : 0;
            CvInvoke.AddWeighted(colors[0],shift, colors[0],0,0,colors[0]);
            shift = (1 + greenshift) > 0 ? (1 + greenshift) : 0;
            CvInvoke.AddWeighted(colors[1], shift, colors[1], 0, 0, colors[1]);
            shift = (1 + blueshift) > 0 ? (1 + blueshift) : 0;
            CvInvoke.AddWeighted(colors[2], shift, colors[2], 0, 0, colors[2]);
            CvInvoke.Merge(colors, dblImg);
            return dblImg;


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

                case ImageProcessingTypes.ColorAdjusting:
                    return getColorAdjusted(ref img, double.Parse(parameters[1]), double.Parse(parameters[2]), double.Parse(parameters[3]));
                default:
                    return img;
            }
        }
    }
}
