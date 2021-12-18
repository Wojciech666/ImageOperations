using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageOperations
{
    internal class ImageScaler
    {
        private ErrorLogger logger = new ErrorLogger();
        public ImageScaler(Image image)
        {
        }

        public Image ScaleImage(Image image, int height)
        {
            double ratio = (double)height / image.Height;
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            try
            {
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.DrawImage(image, 0, 0, newWidth, newHeight);
                }
                image.Dispose();
            }
            catch (Exception ex)
            {
                logger.log(ex.ToString());
            }
            return newImage;
        }

    }
}
