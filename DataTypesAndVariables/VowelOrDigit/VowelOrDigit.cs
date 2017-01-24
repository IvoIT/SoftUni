using System;


namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'u' || input == 'i' || input == 'o' || input == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
