using System;

namespace MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = PowerRaiser(number, power);

            Console.WriteLine(result);
        }

        public static double PowerRaiser(double number, double power)
        {
            double result = 0;

            result = Math.Pow(number, power);

            return result;
        }
    }
}
