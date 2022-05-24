using System;
using System.Linq;
using System.Text;

namespace ImgSteg
{
    class Steganography
    {

        // All encoded messages start with "STG"

        public static void EncodeAndSave(string filePath, string message, string destPath)
        {
            //byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            //BitmapImg img = new BitmapImg(filePath);
            //img.Encode(BitConverter.GetBytes(messageBytes.Length).Reverse().ToArray(), 0);
            //img.Encode(messageBytes, 4 * 8);
            //img.SaveImage(NewFilename(filePath));

            BitmapSimple img = new BitmapSimple(filePath);
            img.Encode("STG" + message);
            img.SaveImage(destPath);
        }

        public static string Decode(string filePath, bool startWithCode)
        {
            //BitmapImg img = new BitmapImg(filePath);
            //byte[] decodedMessage = img.Decode();
            //return System.Text.Encoding.UTF8.GetString(decodedMessage, 0, decodedMessage.Length);

            BitmapSimple img = new BitmapSimple(filePath);
            string message = img.Decode(startWithCode);
            img.disposeImage();

            return message;
        }

        private static string NewFilename(string filePath)
        {
            StringBuilder newName = new StringBuilder();

            if (filePath.LastIndexOf(".") > 0)
            {
                newName.Append(filePath.Substring(0, filePath.LastIndexOf(".")));
            }

            newName.Append("_encoded.png");
            return newName.ToString();
        }

    }
}
