using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Authentication_System
{
    internal class cryptology
    {
        public static string enc(string text, int key)
        {
            char[] chars = text.ToCharArray();
            string enctext = null;

            foreach (char item in chars)
            {
                enctext += Convert.ToChar(item + key);
            }
            return enctext;
        }
        public static string dec(string text, int key)
        {
            char[] chars = text.ToCharArray();
            string dectxt = null;
            foreach (char item in chars)
            {
                dectxt += Convert.ToChar(item - key);
            }
            return dectxt;
        }

    }
}
