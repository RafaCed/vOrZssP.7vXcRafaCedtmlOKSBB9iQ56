using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            int[] multiplicationTable = new int[length];
            for (int i = 0; i < length; i++)
            {
                multiplicationTable[i] = (i + 1) * num;
            }
            Console.WriteLine($"Multiplication table for {num}: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{num} x {i + 1} = {multiplicationTable[i]}");
            }
                
                Console.ReadLine();
        }

    }
}
