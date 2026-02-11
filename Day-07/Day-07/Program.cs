namespace Day_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OrderProcessor processor = new OrderProcessor();

            processor.Process("SKU-100", 2);
            processor.Process("", -1);
            processor.Process("SKU-999", 1);
            processor.Process("SKU-200", 3);
        }
    }
}
