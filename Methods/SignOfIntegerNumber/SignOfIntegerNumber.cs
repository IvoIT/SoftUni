using System;

namespace SignOfIntegerNumber
{
    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            NumberSingPrinter(number);
        }

        public static void NumberSingPrinter(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
