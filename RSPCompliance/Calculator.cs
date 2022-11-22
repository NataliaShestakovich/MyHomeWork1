using RSPComplianceDemo;

namespace RSPCompliance
{
    public static class Calculator
    {
        public static double[] GetExponentiation()
        {
            var random = new Random();

            
            double number = (double)random.Next(0, 1000);

            double powerOfNumber = (double)random.Next(-10, 100);

            double result = Math.Pow(number, powerOfNumber);

            if (double.IsInfinity(result))
            {
                throw new OverflowException();
            }
           
            double[] finalData = { result, number, powerOfNumber };

            return finalData;
        }

        public static int [] GetFactorial()
        {
            var random = new Random();

            int number = random.Next(0, 20);

            int result = 1;

            if (number < 0)
            {
                throw new ArgumentException();
            }
            
            if (number != 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = checked(result * i);                    
                }
            }

            int[] finalData = {result, number};

            return finalData;
        }
    }
}
