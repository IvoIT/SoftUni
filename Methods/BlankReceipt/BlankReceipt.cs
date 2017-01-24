using System;

namespace BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        public static void PrintReceipt()
        {
            BlankReceiptTop();
            BlankReceiptMiddle();
            BlankReceiptBottom();
        }

        public static void BlankReceiptTop()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void BlankReceiptMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void BlankReceiptBottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00a9 SoftUni");
        }
    }
}
