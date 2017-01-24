using System;

namespace CalculateTriangle
{
    public class CalculateTriangle
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(height, width);

            Console.WriteLine(area);
        }

        public static double GetTriangleArea(double height, double width)
        {
            return width * height / 2;
        }
    }
}
