namespace RSPViolationDemo
{
    public static class Calculator
    {
        enum OperationNames
        {
            exponentiation,
            factorial,
        }

        public static void ChooseTheMathOperation(ConsoleKey operation)
        {
            switch (operation)
            {
                case ConsoleKey.D1:
                    GetTheFactorial();
                    break;

                case ConsoleKey.D6:
                    Exponentiate();
                    break;

                default:
                    Console.WriteLine($"Input Error. Please make the right choice.{Environment.NewLine}");
                    break;
            }
        }

        static void PrintResult(OperationNames operationName, double result, int number)
        {
            Console.Clear();
            Console.WriteLine($"Operation: {operationName}{Environment.NewLine}Result: {result}{Environment.NewLine}Random namber for operation: {number}{Environment.NewLine}");
        }

        static void PrintResult(OperationNames operationName, double result, double[] numbers)
        {
                Console.Clear();
                Console.WriteLine($"Operation: {operationName}{Environment.NewLine}Result: {result}{Environment.NewLine}Random namber(s) for operation: {numbers[0]}, exponent:{numbers[1]}{Environment.NewLine}");
        }

        static void Exponentiate()
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

                PrintResult(OperationNames.exponentiation, result, numbers);
            }
        }

        static void GetTheFactorial()
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
                PrintResult(OperationNames.factorial, result, number);
            }
        }
    }

}
