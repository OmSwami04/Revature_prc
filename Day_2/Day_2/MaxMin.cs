using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class MaxMin
    {
        static(int min,int max) findmm(int[] a)
        {
            int min = a[0];
            int max = a[0];

            foreach(int i in a)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
               
            }
            return (min, max);
        }
        static void Main()
        {
            int[] data = { 4, 1, 2, 4, 0, 70 };
            var res = findmm(data);
            Console.WriteLine($"Min={res.min}");
            Console.WriteLine($"Max={res.max}");
        }
    }
}
