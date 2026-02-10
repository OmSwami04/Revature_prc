using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
   public  class ListExample2
    {
        public static void CollectionClassDemo()
        {
            List<int> marks = new List<int>(10);
            marks.Add(1);
            marks.Add(2);
            Console.WriteLine($"Count:{ marks.Count},Capacity:{marks.Capacity}");

            marks.AddRange(new[] { 1, 2, 3, 4 });
            Console.WriteLine($"Count:{marks.Count},Capacity:{marks.Capacity}");

            marks.AddRange(new[] { 1, 2, 3, 4 });
            Console.WriteLine($"Count:{marks.Count},Capacity:{marks.Capacity}");

            Console.WriteLine($"The Avarage{marks.Average()}");

        }
        public static void Main()
        {
            CollectionClassDemo();


        }


    }
}
