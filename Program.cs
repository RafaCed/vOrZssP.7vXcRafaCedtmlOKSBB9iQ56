using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age >= 18)
            {
                Console.WriteLine("You can vote! ");
            }
            if (age <= 18) 
            {
                Console.WriteLine("You can't vote! ");
            }

        }
    }
}
