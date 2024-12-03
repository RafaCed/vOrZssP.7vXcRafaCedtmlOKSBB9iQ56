using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace uppgift21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age > 18)
            {
                Console.WriteLine("Over 18 ");
            }
            else if (age > 30) 
            {
                Console.WriteLine("Over 30 ");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50 ");
            }
            else if (age < 18)
            {
                Console.WriteLine("Under 18 ");
            }

            Console.ReadLine();
        }
    }
}
