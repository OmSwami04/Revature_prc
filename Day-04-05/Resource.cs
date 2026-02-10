using System;

namespace Day04
{
    public class Resource
    {
        public string Name { get; set; }

        // Constructor
        public Resource(string name)
        {
            Name = name;
            Console.WriteLine($"name:{name} is Created");
        }

        // Destructor / Finalizer (called by GC)
        ~Resource()
        {
            Console.WriteLine($"name {Name} Destroyed by GC");
        }
    }
}
