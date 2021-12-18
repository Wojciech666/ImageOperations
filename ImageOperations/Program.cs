using ImageOperations;
using System.Drawing;
using System.Drawing.Imaging;

Image myImage = Image.FromFile("D:\\Zdjecia\\edited\\zjazd.png");
ImageScaler scaledImage = new ImageScaler(myImage);
Image newImage = scaledImage.ScaleImage(myImage,300);
newImage.Save("D:\\Zdjecia\\edited\\scaled.png",ImageFormat.Png);
Console.WriteLine(newImage.Height);