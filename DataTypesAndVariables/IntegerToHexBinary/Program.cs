using System;


namespace IntegerHexOrBinary
{
    public class IntegerHexOrBinary
    {
        public static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            string binaryValue = Convert.ToString(numberInput, 2);
            string hexadecimalValue = numberInput.ToString("X");

            Console.WriteLine(hexadecimalValue);
            Console.WriteLine(binaryValue);
        }
    }
}
