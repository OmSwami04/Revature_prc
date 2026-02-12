using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_07
{
    internal class Try_Catch
    {
        // Entry point method
        static void Main(string[] args)
        {
            try
            {
                // Calling the first method in the call chain
                First();
            }
            catch (DivideByZeroException ex)
            {
                // Specific exception handling
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                // Generic exception handling (always keep at the end)
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
            }
            finally
            {
                // This block always executes
                Console.WriteLine("finally.");
            }

            Console.WriteLine("Program continues after handling the exception.");
        }

        // First method in call chain
        static void First()
        {
            Second();
        }

        // Second method with internal try-catch
        static void Second()
        {
            try
            {
                Third();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception From Third: {ex.Message}");

                // Wrapping original exception inside a new exception
                throw new Exception("My Exception here", ex);
            }
        }

        // Third method that generates DivideByZeroException
        static void Third()
        {
            var numerator = 10;
            var denominator = 0;

            var result = numerator / denominator;
        }

        // Business logic method for custom exception example
        static void AcceptPayment(decimal amount, decimal balance)
        {
            if (amount > balance)
            {
                throw new NotEnoughBalanceException("Not enough balance to complete the payment.");
            }

            Console.WriteLine("Payment accepted.");
        }
    }

    // Base Custom Exception Class
    class BankException : ApplicationException
    {
        public BankException(string message) : base(message)
        {
        }

        public BankException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    // Derived Custom Exception
    class NotEnoughBalanceException : BankException
    {
        public NotEnoughBalanceException(string message) : base(message)
        {
        }

        public NotEnoughBalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
