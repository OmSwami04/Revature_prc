using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Boxing_unboxing
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Object obj = a;
            Console.WriteLine(obj);
            int b = (int)obj;
            Console.WriteLine(b);
        }
        
    }
}
