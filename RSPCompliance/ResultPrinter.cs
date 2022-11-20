using RSPComplianceDemo;

namespace RSPCompliance
{
    public static class ResultPrinter
    {
       public static void PrintResult(OperationNames operationName, double result, int number)
        {
            Console.Clear();
            Console.WriteLine($"Operation: {operationName}{Environment.NewLine}" +
                              $"Result: {result}{Environment.NewLine}" +
                              $"Random namber for operation: {number}{Environment.NewLine}");
        }

       public static void PrintResult(OperationNames operationName, double result, double[] numbers)
        {
                Console.Clear();
                Console.WriteLine($"Operation: {operationName}{Environment.NewLine}" +
                                  $"Result: {result}{Environment.NewLine}" +
                                  $"Random namber(s) for operation: {numbers[0]}, " +
                                  $"exponent:{numbers[1]}{Environment.NewLine}");
        }
    }
}
