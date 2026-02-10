using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Add_overloads
    {
        public void add(double a, double b)
        {
            Console.WriteLine($"Doub:{ a + b}" );
        }
        public void add(decimal a,decimal b)
        {
            Console.WriteLine($"deci:{ a + b}");
        }
        public static void Main()
        {
            Add_overloads a=new Add_overloads();
            a.add(1.12345567897894561231234567891234567894561234567m, 2.123456789789456123123456789789456123m);
        }
    }
}
