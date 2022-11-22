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

                        try
                        {
                            var finalData = Calculator.GetFactorial();

                            PrinterService.PrintResult(finalData);
                        }
                        catch (ArgumentException)
                        {

                            Console.WriteLine("In mathematics, the factorial of a non-negative integer.");
                        }
                        catch (OverflowException)
                        {

                            Console.WriteLine("The result obtained is out of bounds of type.");
                        }
                        
                        break;

                    case ConsoleKey.D6:
                        try
                        {
                            var finalData = Calculator.GetExponentiation();

                            PrinterService.PrintResult(finalData);
                        }
                        catch (OverflowException)
                        {

                            Console.WriteLine("The result obtained is out of bounds of type.");
                        }
                        
                        break;

                    default:
                        Console.WriteLine($"Input Error. Please make the right choice.{Environment.NewLine}");
                        break;
                }
            }
        }
    }
}