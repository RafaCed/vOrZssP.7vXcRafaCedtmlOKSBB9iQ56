using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, 30, 25 };
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            /* or using linq
                using System.Linq;
             int[] numbers = {10, 20, 5, 30, 25};

             int max = numbers.Max();

                 Console.WriteLine($"The max value in the array is: {max}");  */

            Console.WriteLine($"The maximum value in the array is: {max}");

            Console.ReadLine();
        }
    }
}
