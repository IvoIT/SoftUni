using System;

namespace MultiplyEvensByOdd
{
    public class MultiplyEvenByOdd
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultipliesOddByEvenNumbers(number);

            Console.WriteLine(result);

        }

        public static int MultipliesOddByEvenNumbers(int number)
        {
            int evenSum = GetSumOfEvenDiggits(number);
            int oddSum = GetSumOfOddDigits(number);

            int result = evenSum * oddSum;

            return result;
        }

        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number = number / 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

            }

            return sum;
        }

        public static int GetSumOfEvenDiggits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number = number / 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
            }

            return sum;
        }
    }
}
