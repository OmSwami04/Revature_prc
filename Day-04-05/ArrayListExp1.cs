using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class ArrayListExp1
    {
        public static void Main()
        {
            ArrayListDemo();
        }
        public static void ArrayListDemo()
        {
            ArrayList list=new ArrayList();
            list.Add(1);    
            list.Add(2);
            list.Add(3);
            list.Add("Hello");
            list.Add(3.14);

            foreach(Object o in list)
            {
                Console.WriteLine(o);
            }
            int sum = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"{item}, type{item.GetType()}");
                sum += (int)item;//after Hello comes it Throw InvalidCastException
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
