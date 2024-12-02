using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, };
            int sum = SumOfNumbers(numbers);

            Console.WriteLine($"Array length: {numbers.Length}");
            if (sum > -1)
            {
                Console.WriteLine($"Total: {sum}");
            }
            else
            {
                Console.WriteLine("Can't add up an empty array. ");
            }
            if (numbers.Length == 0 || Array.Exists(numbers, element => element < 0))
            {
                Console.WriteLine("Can't add up an empty array. ");
            }
            Console.ReadLine();
        }
      
        static int SumOfNumbers(int[] array)
        { 
        int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
           
        }
    }
}
