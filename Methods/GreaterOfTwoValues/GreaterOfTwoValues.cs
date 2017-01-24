using System;


namespace GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int larger = GetIntMax(first, second);

                Console.WriteLine(larger);
            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char larger = GetCharMax(first, second);

                Console.WriteLine(larger);
            }

            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string larger = GetStringMax(first, second);

                Console.WriteLine(larger);
            }
        }

        public static int GetIntMax(int first, int second)
        {
            int larger = 0;

            if (first >= second)

            {
                larger = first;
            }

            else
            {
                larger = second;
            }

            return larger;
        }

        public static char GetCharMax(char first, char second)
        {
            char larger = (char)0x00;

            if (first >= second)
            {
                larger = first;
            }

            else
            {
                larger = second;
            }

            return larger;
        }

        public static string GetStringMax(string first, string second)
        {
            string larger = string.Empty;

            if (first.CompareTo(second) >= 0)
            {
                larger = first;
            }
            else
            {
                larger = second;
            }

            return larger;
        }
    }
}
