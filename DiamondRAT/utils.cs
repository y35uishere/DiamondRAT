using System.Drawing;
using System.IO;

namespace DiamondRAT
{
    class utils
    {
        public static int CountCharacter(string value, char ch)
        {
            int num = 0;
            checked
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == ch)
                    {
                        num++;
                    }
                }
                return num;
            }
        }

        public static Image ByteArray2Image(byte[] ByAr)
        {
            try
            {
                MemoryStream stream = new MemoryStream(ByAr);
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }
    }
}
