using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservedChars
{
    class ReservedChars
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string thirdChar = Console.ReadLine();

            Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");

        }
    }
}
