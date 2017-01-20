using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int numberInputOne = int.Parse(Console.ReadLine());
            int numberInputTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:");
            Console.WriteLine($"a = {numberInputOne} ");
            Console.WriteLine($"b = {numberInputTwo}");

            Console.WriteLine($"After:");
            Console.WriteLine($"a = {numberInputTwo} ");
            Console.WriteLine($"b = {numberInputOne}");


        }
    }
}
