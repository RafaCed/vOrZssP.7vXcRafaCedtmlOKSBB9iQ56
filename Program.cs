using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, };
            int sum = numbers.Sum();
            
            Console.WriteLine("Sum of numbers: " + sum);

            Console.ReadLine();
        }
    }
}
