using System;
using System.Collections.Generic;
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
                pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
                return stream.ToArray();
            }
        }
    }
}
