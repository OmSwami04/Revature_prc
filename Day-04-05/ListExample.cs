using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class ListExample
    {
        public static void Main()
        {
            ListExample obj = new ListExample();
            obj.ListEx();
        }
        public void ListEx()
        {
            Collection<string> l = new Collection<string>();
            l.Add("10");
            l.Add("om");
            l.Add("25");

            foreach(var i in l)
            {
                Console.WriteLine(i);
            }
        }
    }
}
