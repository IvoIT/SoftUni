using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string wordInput = Console.ReadLine();


            bool output = Convert.ToBoolean(wordInput);

            if (output == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
