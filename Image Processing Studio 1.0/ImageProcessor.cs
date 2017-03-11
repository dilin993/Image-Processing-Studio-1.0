using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;


namespace Image_Processing_Studio_1._0
{
    static class ImageProcessingTypes
    {
        public const string Sharpening = "sharpening";
    }

    class ImageProcessor
    {
        public static Mat getSharpened(Mat img, double sigma, double amount)
        {
            /// <summary>
            /// Apply sharpening to the given mat.
            /// </summary>
            /// <param name="img">The src Mat.</param>
            /// <param name="sigma">Sigma value for shrpening.</param>
            /// <param name="amount">Amount of sharpening required.</param>
            /// <returns>
            /// Sharpened Mat image.
            /// </returns>
            /// <remarks>
            /// Used for image sharpening.
            /// </remarks>

            Mat dblImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            Mat dblBlurImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            Mat outImg = new Mat(img.Rows, img.Cols, Emgu.CV.CvEnum.DepthType.Cv64F, img.NumberOfChannels);
            img.ConvertTo(dblImg, Emgu.CV.CvEnum.DepthType.Cv64F);
            int k = 2 * (int)Math.Round(3.0 * sigma) + 1;
            CvInvoke.GaussianBlur(dblImg, dblBlurImg, new Size(k, k), sigma, sigma);
            CvInvoke.AddWeighted(dblImg, 1.0 + amount, dblBlurImg, -amount, 0, outImg);
            dblImg.Dispose();
            dblBlurImg.Dispose();
            return outImg;
        }

        public static Mat getResult(Mat img, string[] parameters)
        {
            /// <summary>
            /// Apply image processing operation to the given mat.
            /// </summary>
            /// <param name="img">The src Mat.</param>
            /// <param name="parameters">Define parameters of the operation.</param>
            /// <returns>
            /// Processed Mat image.
            /// </returns>
            /// <remarks>
            /// Used for image processing.
            /// </remarks>
            /// 
            switch (parameters[0].ToLower())
            {
                case ImageProcessingTypes.Sharpening:
                    return getSharpened(img, double.Parse(parameters[1]), double.Parse(parameters[2]));

                default:
                    return img;
            }
        }
    }
}
