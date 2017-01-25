using System;

namespace HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string nameInput = Console.ReadLine();
            string helloUser = HelloUser(nameInput);

            Console.WriteLine(helloUser);

        }

        public static string HelloUser(string nameInput)
        {
            string helloUser = $"Hello, {nameInput}!";

            return helloUser;
        }
    }
}
