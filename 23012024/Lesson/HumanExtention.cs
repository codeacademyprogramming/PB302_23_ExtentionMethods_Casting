using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal static class HumanExtention
    {
        public static string GetFullName(this Human hmn)
        {
            return hmn.Name + " " + hmn.Surname;
        }
    }
}
