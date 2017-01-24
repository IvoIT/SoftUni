using System;

namespace DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            SquarePrinter(number);

        }

        public static void SquarePrinter(int number)
        {
            SquareTopAndBottom(number);
            SquareMiddle(number);
            SquareTopAndBottom(number);
        }

        public static void SquareTopAndBottom(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        public static void SquareMiddle(int number)
        {
            for (int rowNumber = 1; rowNumber <= number - 2; rowNumber++)
            {
                Console.Write('-');

                for (int i = 1; i < number; i++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
