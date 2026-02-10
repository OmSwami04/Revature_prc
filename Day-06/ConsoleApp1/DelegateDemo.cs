using System;

namespace ConsoleApp1
{
    public class DelegateDemo
    {
        public void Run()
        {
            // ---------- Func ----------
            Func<int, int, int> genericOperation = Add;

            // Multicast delegate
            genericOperation += Sub;
            genericOperation += Mul;

            Console.WriteLine("---- Func (Multicast) ----");
            int result = genericOperation(5, 3); // only Mul result is stored
            Console.WriteLine($"Final result stored: {result}");

            // ---------- Action ----------
            Action<string> action = PrintMessage;
            action("Hello from Action delegate!");

            // ---------- Predicate ----------
            Predicate<int> predicate = IsEven;
            int testNumber = 4;
            Console.WriteLine($"Is {testNumber} even? {predicate(testNumber)}");

            // ---------- Func with string ----------
            Func<string, string, string> stringOperation = Concatenate;
            var text = stringOperation("Hello, ", "World!");
            Console.WriteLine(text);
        }

        // ---------- Methods ----------
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public string Concatenate(string a, string b)
        {
            return a + b;
        }

        public int Add(int a, int b)
        {
            Console.WriteLine($"Add: {a + b}");
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine($"Sub: {a - b}");
            return a - b;
        }

        public int Mul(int a, int b)
        {
            Console.WriteLine($"Mul: {a * b}");
            return a * b;
        }
    }

   
}
