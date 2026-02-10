using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Value_and_Ref
    {
       
        public static void m1(int a)
        {
            a = 100;
        }
        public static void m2(ref int b)
        {

            b = 500;
        }

        static void Main()
        {
            int a = 200;
            //m1(a);
            Console.WriteLine(a);
            m2(ref a);
            Console.WriteLine(a);

        }
    }
}
