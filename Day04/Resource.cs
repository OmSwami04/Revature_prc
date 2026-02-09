using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Resource
    {
        public string Name { get; set; }
        public Resource(string name)
        {
            Name = name;
            Console.WriteLine($"name:{name} is Created");

        }
        ~Resource()//this is Destructor(finalizer)
        {
            Console.WriteLine($"name{Name} Destroyed by GC");

        }
    }
}
