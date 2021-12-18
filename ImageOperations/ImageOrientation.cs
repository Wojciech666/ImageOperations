using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOperations
{
    internal class ImageOrientation
    {
        public bool IsVertical { get; private set; }

        public ImageOrientation(Image image)
        {
            this.CheckForVerticalImage(image);
        }

        private void CheckForVerticalImage(Image image)
        {
            if (image.Height > image.Width)
            {
                this.IsVertical = true;
            }
            else
            {
                this.IsVertical = false;
            }
        }
    }
}
