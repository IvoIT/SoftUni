using System;


namespace FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numberInput; i++)
            {
                bool primeChecker = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        primeChecker = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {primeChecker}");
            }

        }
    }
}
