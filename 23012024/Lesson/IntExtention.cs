using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal static class IntExtention
    {
        public static int Add(this int num,int addition)
        {
            return num+ addition;
        }

        public static int Sqrt(this int num)
        {
            return num * num;
        }
    }
}
