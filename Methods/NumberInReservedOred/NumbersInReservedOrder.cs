using System;
using System.Linq;

namespace NumbersInReservedOrder
{
    public class NumbersInReservedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();

        }
    }
}
