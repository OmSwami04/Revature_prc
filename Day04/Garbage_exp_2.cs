using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Garbage_exp_2
    {
        public static void Main(string[] args)
        {
            //GC demonitration
            var res1 = new Resource("Res1");//allcated in heap
            var res2 = new Resource("Res2");

            res1 = null;//res1 noweligible for collection
            res2 = res2;//res2 still refrance

            GC.Collect();
            Console.WriteLine("GC Complete");

        }

    }
}
