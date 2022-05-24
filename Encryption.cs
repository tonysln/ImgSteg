using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ImgSteg
{
    class Encryption
    {
        // https://codereview.stackexchange.com/questions/157603/rc4-implementation

        public static string Rc4(string input, string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] key = Encoding.UTF8.GetBytes(password);

            byte[] z = new byte[bytes.Length];
            byte[] s = new byte[256];
            byte[] k = new byte[256];
            byte temp;
            int i, j;

            for (i = 0; i < 256; i++)
            {
                s[i] = (byte)i;
                k[i] = key[i % key.GetLength(0)];
            }

            j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + s[i] + k[i]) % 255;
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            i = j = 0;
            for (int x = 0; x < z.Length; x++)
            {
                i = (i + 1) % 255;
                j = (j + s[i]) % 255;
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                int t = (s[i] + s[j]) % 255;
                z[x] = (byte)(bytes[x] ^ s[t]);
            }

            return Encoding.UTF8.GetString(z, 0, z.Length);
        }

        public static string Rotate(string input, int shift)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");

            shift = ((shift % 26) + 26) % 26;

            foreach (char c in input)
            {
                char letter = c;

                if (regex.IsMatch(letter.ToString()))
                {
                    if (letter >= 'a' && letter <= 'z')
                        letter = (char) ((letter - 'a' + shift) % 26 + 'a');
                    else if (letter >= 'A' && letter <= 'Z')
                        letter = (char) ((letter - 'A' + shift) % 26 + 'A');
                }

                result.Append(letter);
            }

            return result.ToString();
        }

        public static string DeRotate(string input, int shift)
        {
            return Rotate(input, 26 - shift);
        }

    }
}
