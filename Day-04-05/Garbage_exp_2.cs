using System;

namespace Day04
{
    public class Garbage_exp_2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---- GC DEMO ----");
            ResourceDemo();

            Console.WriteLine("\n---- IDisposable DEMO ----");
            DisposableDemo();

            Console.WriteLine("\n---- Record / Class / Struct DEMO ----");
            RecordDemo();
        }

        // ================= GC Demo =================
        private static void ResourceDemo()
        {
            var res1 = new Resource("Res1");
            var res2 = new Resource("Res2");

            res1 = null;   // eligible for GC
            res2 = res2;   // still referenced

            GC.Collect();                     // force GC (demo only)
            GC.WaitForPendingFinalizers();    // wait for finalizer

            Console.WriteLine("GC Complete");
        }

        // ============== IDisposable Demo ==========
        private static void DisposableDemo()
        {
            using (var manager = new Garbage_exp())
            {
                manager.OpenFile("test.txt");
            }

            Console.WriteLine("Dispose Complete");
        }

        // ============== Record Demo ===============
        private static void RecordDemo()
        {
            var c1 = new TempClass(1, "ClassObj");
            var r1 = new Temp { Id = 2, Name = "RecordObj" };
            var s1 = new TempStruct { Id = 3, Name = "StructObj" };

            Console.WriteLine($"Class  : {c1.Id}, {c1.Name}");
            Console.WriteLine($"Record : {r1.Id}, {r1.Name}");
            Console.WriteLine($"Struct : {s1.Id}, {s1.Name}");
        }
    }
}
