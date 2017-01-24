using System;

namespace Printing_Triangle
{
    public class Printing_Triangle
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);

        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int number)
        {
            for (int line = 1; line <= number; line++)
            {
                PrintLine(1, line);
            }

            for (int line = number - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

    }
}