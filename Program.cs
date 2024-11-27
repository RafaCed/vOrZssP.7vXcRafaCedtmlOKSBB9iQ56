using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int number;
            while (!int.TryParse(Console.ReadLine(), out number));
            {
                Console.WriteLine("Enter a valid integrer");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd. ");
            }


          Console.ReadLine();
        }
    }
}
