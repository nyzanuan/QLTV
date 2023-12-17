using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GUI.Helper
{
    public static class HelperImage
    {
        public static byte[] ChangeImageToByte(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return new byte[0];
            }

            using (MemoryStream stream = new MemoryStream())
            {
                using (Bitmap bitmap = new Bitmap(pictureBox.Image))
                {
                    ImageFormat format = ImageFormat.Jpeg; // Đặt định dạng mặc định là JPEG

                    if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                    {
                        format = ImageFormat.Png; // Nếu là 24-bit RGB, chọn PNG
                    }

                    bitmap.Save(stream, format);
                    return stream.ToArray();
                }
                //pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
                //return stream.ToArray();
            }
        }
    }
}
