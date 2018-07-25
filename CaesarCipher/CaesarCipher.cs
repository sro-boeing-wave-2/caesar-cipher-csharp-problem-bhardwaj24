using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static String Rotate(string text, int shiftKey)
        {
            StringBuilder str = new StringBuilder();
            int i;
            for (i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    char lower = (Char.IsLower(text[i]) ? 'a' : 'A');
                    str.Append((char)((text[i] + shiftKey - lower) % 26 + lower));
                }
                else
                {
                    str.Append(text[i]);
                }
            }
            return str.ToString();
        }
    }
}
