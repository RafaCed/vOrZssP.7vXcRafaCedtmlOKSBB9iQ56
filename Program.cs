using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());


         


            switch (grade)
            {
                case 5:
                    Console.WriteLine("Grade 5");
                    break;
                case 4:
                    Console.WriteLine("Grade 4");
                    break;
                case 3:
                    Console.WriteLine("Grade 3");
                    break;
                case 2:
                    Console.WriteLine("Grade 2");
                    break;
                case 1:
                    Console.WriteLine("Grade 1");
                    break;
                case 0:
                    Console.WriteLine("Failed");
                    break;

                default:
                    Console.WriteLine("Invalid, enter a value between 0 and 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
