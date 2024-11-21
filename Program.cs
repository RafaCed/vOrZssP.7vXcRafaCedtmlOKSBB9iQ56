using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();

            int age = Convert.ToInt32(ageInput);
            
            const int LegalAge = 18;
            if (age >= LegalAge)
            {
                Console.WriteLine("You're an adult. ");
            }
            else
            {
                Console.WriteLine("You're a minor. ");
            }

            int Counter = 1;
            while (Counter <= 5)
            {
                Console.WriteLine("Counter: " + Counter);
                Counter++;
            }
            
            switch (Counter) 
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;


            }
         var name = "John";
         Console.WriteLine($"Welcome {name}! The value of counter after the loop is {Counter}.");



        }
    }
}
