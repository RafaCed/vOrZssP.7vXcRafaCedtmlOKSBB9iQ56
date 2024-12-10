using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace uppgift23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (TryParseInt(input, out number))
            {
                Console.WriteLine($"Converted number: {number}");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        static bool TryParseInt(string input, out int result)
        {
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception e)
            {
                result = 0;
                return false;
            }
            
        }
    }
}
