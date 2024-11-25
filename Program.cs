using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter a message: ");
            string message = Console.ReadLine();
            //2
            if (string.IsNullOrEmpty(message))
            {
                message = ("C# is fun but inferior to Python. ");

            }
            Console.WriteLine("\nOriginal order: ");
            Console.WriteLine(message);
            //3
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            Console.WriteLine("\nMessage in reverse order: ");
            Console.WriteLine(new string(messageArray));
            Console.WriteLine();
            //4
            foreach (char letter in message)
            {
                Console.WriteLine(letter);
            }
            //5
            Console.WriteLine("\nMessage from top to bottom in reverse, letter by letter:");
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(message[i]);
            }
            Console.ReadLine();
        }
    }
}
