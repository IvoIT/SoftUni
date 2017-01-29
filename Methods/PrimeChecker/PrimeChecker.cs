using System;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            double numberInput = double.Parse(Console.ReadLine());

            if (IsPrime(numberInput))
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }

        }

        public static bool IsPrime(double number)
        {
            bool IsPrime = true;
            int maxDivider = (int)Math.Sqrt(number);

            if (number == 0 || number == 1)
            {
                IsPrime = false;
                return IsPrime;
            }

            for (int i = 2; i <= maxDivider; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            return IsPrime;
        }
    }
}
