using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal static class StringExtention
    {
        public static string GetFirstWord(this string str)
        {
            int wantedIndex = str.IndexOf(' ');
            int startIndex = 0;
            int length = wantedIndex - startIndex;

            return str.Substring(startIndex,length);
        }

        public static string GetUpper(this string str, int length)
        {
            return str.Substring(0,length).ToUpper();
        }
    }
}
