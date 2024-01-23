using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal static class Calculator
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
