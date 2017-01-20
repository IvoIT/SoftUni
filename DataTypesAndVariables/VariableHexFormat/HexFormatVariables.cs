using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableHexFormat
{
    class HexFormatVariables
    {
        static void Main(string[] args)
        {

            string hexValue = Console.ReadLine();

            int decimalValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(decimalValue);

        }
        
    }
}
