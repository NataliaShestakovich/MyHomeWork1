namespace RSPCompliance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Choose a math operation.  To select an operation, press one of the following keys{Environment.NewLine}");

                Console.WriteLine($"^ - raising to power!{Environment.NewLine}" +
                                  $"! - factorial{Environment.NewLine}" +
                                  $"esc - exit{Environment.NewLine}");

                ConsoleKey choice = Console.ReadKey().Key;

                if (choice == ConsoleKey.Escape)
                {
                    break;
                }

                Console.Clear();

                switch (choice)
                {
                    case ConsoleKey.D1:
                        Calculator.GetTheFactorial();
                        break;
                    case ConsoleKey.D6:
                        Calculator.Exponentiate();
                        break;
                    default:
                        Console.WriteLine($"Input Error. Please make the right choice.{Environment.NewLine}");
                        break;
                }
            }
        }
    }
}