using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class DelegateDemo
    {
        //delegate int MathOperation(int a,int b);
        // Generic Delegate

        // delegate TResult GenericTwoParameterFunction<TFirst, TSecond, TResult>(TFirst a, TSecond b);

        delegate void GenericTwoParameterAtion<TFirst, TSecond>(TFirst a, TSecond b);

        public void Run()
        {
            //   MathOperation op = Add;
            // GenericTwoParameterFunction<int, int, int> genericOperation = Add;
            Func<int, int, int> genericOperation = Add;

            Action<string> action = PrintMessage;
            action("Hello from Action delegate!");

            Predicate<int> predicate = IsEven;
            int testNumber = 4;

            Console.WriteLine($"Is {testNumber} even? {predicate(testNumber)}");

            return;

            Func<string, string, string> stringOperation = Concatenate;

            var x = stringOperation("Hello, ", "World!");
            Console.WriteLine($"Concatenation result: {x}");

            //multicast deligate : adding more methodes to invocate it
            //op += Sub;
            //op -= Mul;
            //op+= Div;
            //Removing the subtract method
            //var result = op(5, 3);
            //Console.WriteLine($"The Result is: {result}");
            // Multicast delegate: adding more methods to the invocation list
            genericOperation += Sub;
            genericOperation += Mul;
            genericOperation += Div;

            genericOperation -= Sub; // Removing the Subtract method from the invocation list

            var result = genericOperation(5, 3);
            Console.WriteLine($"Final result: {result}");
        }

        public int square(int x)
        {
            return x * x;
        }

        // Lambda Expression Demo
        public void LambdaExpressionDemo()
        {
            Func<int, int> f;

            f = (int x) => x * x;

            var result = f(5);

            Console.WriteLine($"result: {result}");
        }

        // Anonymous Method Demo
        public void AnonymousMethodDemo()
        {
            // Using an anonymous method with a delegate
            Func<int, int, int> operation = delegate (int a, int b)
            {
                Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
                return a + b;
            };

            operation(5, 3);
        }

        void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public string Concatenate(string a, string b)
        {
            string result = a + b;
            Console.WriteLine($"Concatenating '{a}' and '{b}' results in: '{result}'");
            return result;
        }

        public int Add(int a, int b)
        {
            Console.WriteLine($"the val A:{a} and B:{b} and Sum is: {a + b}");
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine($"the val A:{a} and B:{b} and Sub is: {a - b}");
            return a - b;
        }

        public int Mul(int a, int b)
        {
            Console.WriteLine($"the val A:{a} and B:{b} and Mul is: {a * b}");
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"the val A:{a} and B:{b} and Div is: {a / b}");
                return a * b;
            }
            else
            {
                Console.WriteLine("the value is Invalid ");
                return 0;
            }
        }
    }
}
