using RSPComplianceDemo;

namespace RSPCompliance
{
    public static class PrinterService
    {
       public static void PrintResult(int[] finalDate)
        {
            Console.Clear();
            Console.WriteLine($"Operation: {OperationNames.factorial}{Environment.NewLine}" +
                              $"Result: {finalDate[0]}{Environment.NewLine}" +
                              $"Random namber for operation: {finalDate[1]}{Environment.NewLine}");
        }

       public static void PrintResult(double[] finalDate)
        {
                Console.Clear();
                Console.WriteLine($"Operation: {OperationNames.exponentiation}{Environment.NewLine}" +
                                  $"Result: {finalDate[0]}{Environment.NewLine}" +
                                  $"Random namber(s) for operation: {finalDate[1]}, " +
                                  $"power of number:{finalDate[2]}{Environment.NewLine}");
        }

    }
}
