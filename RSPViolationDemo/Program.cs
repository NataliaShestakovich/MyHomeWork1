namespace RSPViolationDemo
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

                   Calculator.ChooseTheMathOperation(choice);
                }
            }
    }
}