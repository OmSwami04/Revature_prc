using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Nullable
    {
        
        
        public static void Main()
        {
            int a = 10;
            //int b = null;
            int? b = null;
            if (b == null)
            {
                Console.WriteLine("null");
            }
        }
    }
}
