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
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            return stream.ToArray();
        }
    }
}
