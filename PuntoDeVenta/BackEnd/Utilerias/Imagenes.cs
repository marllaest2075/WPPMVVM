using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Utilerias
{
    public static class Imagenes
    {
        public static byte[] ToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image ToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static string FileTo_S(string imgPath)
        {
            byte[] imageBytes = File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        public static byte[] FileTo_Bytes(string imgPath)
        {
            byte[] imageBytes = File.ReadAllBytes(imgPath);

            return imageBytes;
        }

        public static string ImagenTo_S(Image imageIn)
        {
            string base64String = "";
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Png);
                base64String = Convert.ToBase64String(ms.ToArray());
            }
            return base64String;
        }

        public static Image S_ToImage(string StringBase)
        {
            Image img = null;
            if (!string.IsNullOrEmpty(StringBase))
            {
                byte[] Pd = Convert.FromBase64String(StringBase);
                MemoryStream memstr = new MemoryStream(Pd);
                img = Image.FromStream(memstr);
            }
            return img;
        }
    }
}