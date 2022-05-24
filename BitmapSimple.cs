using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgSteg
{
    class BitmapSimple
    {

        // Some of the code by https://github.com/AlexMaclean
        // All encoded messages start with "STG"

        private Bitmap bitmapImage;

        public BitmapSimple(string path)
        {
            /* Release resources after opening the image. */
            using (var bmpTemp = new Bitmap(path))
            {
                this.bitmapImage = new Bitmap(bmpTemp);
            }
        }

        public void SaveImage(string path)
        {
            bitmapImage.Save(path);
            disposeImage();
        }

        public void disposeImage()
        {
            bitmapImage.Dispose();
        }

        public void Encode(string message)
        {
            for(int i = 0; i <= message.Length; i++) 
            {
                byte b = (byte)((i == message.Length) ? 0x00 : BitConverter.GetBytes(message[i])[0]);
                bool b1 = GetBit(b, 1);
                bool b2 = GetBit(b, 2);
                bool b3 = GetBit(b, 3);
                bool b4 = GetBit(b, 4);
                bool b5 = GetBit(b, 5);
                bool b6 = GetBit(b, 6);
                bool b7 = GetBit(b, 7);
                bool b8 = GetBit(b, 8);
                ModifyPixel(i * 3, b1, b2, b3);
                ModifyPixel(i * 3 + 1, b4, b5, b6);
                ModifyPixel(i * 3 + 2, b7, b8, false);
            }
        }

        public string Decode(bool startWithCode) 
        {
            string result = string.Empty;
            int i = 0;
            while (true)
            {
                Color c1, c2, c3;

                c1 = GetColor(i++);
                c2 = GetColor(i++);
                c3 = GetColor(i++);

                byte c = GetChar(c1, c2, c3);
                if (c == 0x00) break;
                
                result += (char) c;
            }

            /* Check for code 'STG', else return nothing */
            if (startWithCode)
            {
                if (result.StartsWith("STG")) return result.Substring(3);
                else return "";
            } 

            /* Otherwise return anything at all (random characters most of the time) */
            return result;
        }

        private void ModifyPixel(int i, bool r, bool g, bool b)
        {
            int x = i % bitmapImage.Width;
            int y = i / bitmapImage.Width;

            Color color = bitmapImage.GetPixel(x, y);

            byte red = ChangeBit(color.R, r, 0x01);
            byte green = ChangeBit(color.G, g, 0x01);
            byte blue = ChangeBit(color.B, b, 0x01);

            Color newColor = Color.FromArgb(color.A, red, green, blue);

            bitmapImage.SetPixel(x, y, newColor);
        }

        public Color GetColor(int i)
        {
            int x = i % bitmapImage.Width;
            int y = i / bitmapImage.Width;

            if (x >= bitmapImage.Size.Width || y >= bitmapImage.Size.Height)
            {
                throw new Exception("Out of range.");
            }

            return bitmapImage.GetPixel(x, y);
        }

        public static bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber - 1)) != 0;
        }

        private static byte ChangeBit(byte i, bool bit, byte index)
        {
            if (bit) return (byte)(i | index);
            return (byte)(i & ~index);
        }

        private byte GetChar(Color c1, Color c2, Color c3)
        {
            byte b = 0x00;
            b = ChangeBit(b, GetBit(c1.R, 0x01), 0x01);
            b = ChangeBit(b, GetBit(c1.G, 0x01), 0x02);
            b = ChangeBit(b, GetBit(c1.B, 0x01), 0x04);

            b = ChangeBit(b, GetBit(c2.R, 0x01), 0x08);
            b = ChangeBit(b, GetBit(c2.G, 0x01), 0x10);
            b = ChangeBit(b, GetBit(c2.B, 0x01), 0x20);

            b = ChangeBit(b, GetBit(c3.R, 0x01), 0x40);
            b = ChangeBit(b, GetBit(c3.G, 0x01), 0x80);
            return b;
        }

    }
}
