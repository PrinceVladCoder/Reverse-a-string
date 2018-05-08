using System;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            Console.WriteLine(" ");
            Console.WriteLine("Please enter your name:");

            string userName = Console.ReadLine();
            Console.WriteLine("Hallo " + userName + " lets reverse your name");
            Console.Clear();
            Console.WriteLine(userName);
            char[] inputArray = userName.ToCharArray();
            Array.Reverse(inputArray);
            string reversed = new string (inputArray);
            Console.WriteLine(reversed);
        }  
    }
}
