using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift27
{
    internal class Program
    {
        class MathOperations
        {
            public int Addition(int a, int b)
            { return a + b; }
            public int Subtraction(int a, int b)
            { return a - b; }
            public int Multiplication(int a, int b)
            { return a * b; }
            public double Division(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                return (double)a / b;
            }

            public double Power(int baseNum, int exponent)
            { return Math.Pow(baseNum, exponent); }
        }
        
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition: {mathOps.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {mathOps.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {mathOps.Multiplication(num1, num2)}");
            
            try
            {
                Console.WriteLine($"Division: {mathOps.Division(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            { 
                Console.WriteLine(ex.Message); 
            }

            Console.WriteLine("Enter the exponent for power operation: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Power: {mathOps.Power(num1, exponent)}");
            Console.ReadLine();
        }
    }
}
