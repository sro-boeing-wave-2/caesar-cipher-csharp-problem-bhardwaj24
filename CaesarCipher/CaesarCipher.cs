using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            int i,c=0,shift=0;
            string str="";
            for(i=0;i<text.Length;i++)
            {
                c = (int)text[i];
                if(c>=65 && c<=90)
                {
                    shift = c + shiftKey;
                    if(shift>90)
                    {
                        shift = shift - 26;
                        str += (char)shift;
                    }
                    else
                    {

                        str += (char)shift;
                    }
                }
                else if(c >= 97 && c <= 122)
                {
                    shift = c + shiftKey;
                    if (shift > 122)
                    {
                        shift = shift - 26;
                        str += (char)shift;
                    }
                    else
                    {
                        str += (char)shift;
                    }
                }
                else
                {
                    str = str + text[i];
                }
            }
            return str;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
