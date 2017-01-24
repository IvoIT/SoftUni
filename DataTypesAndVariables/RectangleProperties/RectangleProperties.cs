using System;

namespace RectangleProperties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectanglePerimeter = 2 * (width + height);
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
