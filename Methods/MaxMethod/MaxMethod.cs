using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int maxNumber = BiggerNumber(numberOne, numberTwo, numberThree);

            Console.WriteLine(maxNumber);
        }

        public static int BiggerNumber(int numberOne, int numberTwo, int numberThree)
        {
            int maxNumber = 0;

            if (numberOne >= numberTwo && numberOne >= numberThree)
            {
                maxNumber = numberOne;
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                maxNumber = numberTwo;
            }

            else
            {
                maxNumber = numberThree;
            }

            return maxNumber;
        }
    }
}
