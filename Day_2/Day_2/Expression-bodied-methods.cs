using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Day_2
{
    internal class Expression_bodied_methods
    {
        public int Add(int a, int b) => a + b;
        public static void Main(string[] args)
        {
            Expression_bodied_methods b=new Expression_bodied_methods();
            int res=b.Add(1, 2);
            Console.WriteLine(res);
        }
    }
}
