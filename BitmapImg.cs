using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;

namespace ImgSteg
{
    class BitmapImg
    {

        private Bitmap bufferedImage;
        private Bitmap userSpaceImage;
        private byte[] bufferedImageBytes;
        private byte[] userSpaceImageBytes;

        public BitmapImg(string path)
        {
            this.bufferedImage = new Bitmap(path);
            GenerateUserSpaceImage();
            GenerateUserSpaceImageBytes();
            GenerateBufferedImageBytes();
        }

        private void GenerateUserSpaceImage()
        {
            this.userSpaceImage = new Bitmap(bufferedImage.Width, bufferedImage.Height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            //userSpaceImage.SetResolution(bufferedImage.HorizontalResolution, bufferedImage.VerticalResolution);
            Graphics graphics = Graphics.FromImage(userSpaceImage);
            graphics.DrawImage(bufferedImage, new Point(0,0));
            graphics.Dispose();
        }

        private void GenerateUserSpaceImageBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                userSpaceImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                userSpaceImageBytes = ms.ToArray();
            }

        }

        private void GenerateBufferedImageBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bufferedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                bufferedImageBytes = ms.ToArray();
            }
        }

        public void SaveImage(string path)
        {
            userSpaceImage.Save(path);
        }

        public void Encode(byte[] message, int offset)
        {
            if (message.Length + offset > userSpaceImageBytes.Length)
            {
                throw new ArgumentException("Image is not long enough to store the provided message");
            }

            for (int i = 0; i < message.Length; i++)
            {
                uint additionByte = message[i];

                for (int bit = 7; bit >= 0; --bit, offset++)
                {
                    int b = (int) (additionByte >> bit) & 0x1;
                    userSpaceImageBytes[offset] = (byte)((userSpaceImageBytes[offset] & 0xFE) | b);
                }
            }
        }

        public byte[] Decode()
        {
            int length = 0;
            int offset = 4 * 8;

            for (int i = 0; i < offset; i++)
            {
                length = (length << 1) | (userSpaceImageBytes[i] & 0x1);
            }

            byte[] result = new byte[0];

            try
            {
                result = new byte[length];

                for (int b = 0; b < result.Length; b++)
                {
                    for (int i = 0; i < 8; i++, offset++)
                    {
                        result[b] = (byte)((result[b] << 1) | (userSpaceImageBytes[offset] & 0x1));
                    }
                }
            } 
            catch (OverflowException e)
            {
                Console.WriteLine("There was a problem reading the image.");
                Console.WriteLine(e.StackTrace);
            }

            return result;
        }

    }
}
