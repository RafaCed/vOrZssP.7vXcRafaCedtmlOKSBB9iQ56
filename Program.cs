using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift26
{
    class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            try
            {
                return (double)numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
                return 0.0;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
                return 0.0;
            }
        }
        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value. ");
                return -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small.");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            try
            {
                Console.Write("Enter a numerator: ");
                string numeratorInput = Console.ReadLine();
                int numerator = calculator.ParseInput(numeratorInput);

                if (numerator == -1)
                { return; }

                Console.Write("Enter a denominator: ");
                string denominatorInput = Console.ReadLine();
                int denominator = calculator.ParseInput(denominatorInput);

                if (denominator == -1)
                { return; }

                double result = calculator.Divide(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine($"Unexpected error occurred in the main method. {ex.Message}");
            }
        }
    }
}
