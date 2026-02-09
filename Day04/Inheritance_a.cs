using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
     class Inheritance_a
    {
       public  static int var1 = 10;
        public  int var2 = 10;
        public void m1()
        {
            Console.WriteLine("exp1");
        }
        public static void m2()
        {
            Console.WriteLine("m2");
        }
    }
    class Demo_a : Inheritance_a
    {
        public static void Main()
        {
            Demo_a obj=new Demo_a();
            obj.m1();
            //obj.m2();-->Static methods ARE inherited, but they belong to the CLASS, not the object.
            Inheritance_a.m2();
            Console.WriteLine(obj.var2);
            Console.WriteLine(obj.var2.GetType());
            Console.WriteLine(typeof(Demo_a));
        }
    }
}
