namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo d = new DelegateDemo();
            // d.Run();
            //d.LambdaExpressionDemo();
            //d.AnonymousMethodDemo();
            // d.HighOrderFunction();

            Button button = new Button();

            // Subscriber: Door bell
            button.OnClick += () => Console.WriteLine("Bell Rings!");

            // Subscriber: Electricity Board
            button.OnClick += () => Console.WriteLine("Charge for Electricity!");

            // Other subscribers
            button.OnClick += () => Console.WriteLine("Third!");
            button.OnClick += () => Console.WriteLine("Fourth!");

            // Raise Event
            button.Click();
        }
    }
}
