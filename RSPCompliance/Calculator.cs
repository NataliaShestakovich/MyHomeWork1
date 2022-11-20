using RSPComplianceDemo;

namespace RSPCompliance
{
    public static class Calculator
    {
        public static void Exponentiate()
        {
            var random = new Random();

            double number = (double)random.Next(0, 1000);

            double powerOfNumber = (double)random.Next(-10, 100);

            double result = Math.Pow(number, powerOfNumber);

            if (double.IsInfinity(result))
            {
                Console.WriteLine($"{Environment.NewLine}The result obtained is out of bounds of type double.");
            }
            else
            {
                double[] numbers = { number, powerOfNumber };

                ResultPrinter.PrintResult(OperationNames.exponentiation, result, numbers);
            }
        }

        public static void GetTheFactorial()
        {
            var random = new Random();

            int number = random.Next(0, 100);

            int result = 1;

            if (number < 0)
            {
                Console.WriteLine($"{Environment.NewLine}In mathematics, the factorial of a non-negative integer.");
            }
            if (number != 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    try
                    {
                        result = checked(result * i);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The result obtained is out of bounds of type int.");

                        break;
                    }
                }
                ResultPrinter.PrintResult(OperationNames.factorial, result, number);
            }
        }
    }
}
