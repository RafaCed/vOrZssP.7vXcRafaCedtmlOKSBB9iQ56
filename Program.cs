using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            int num1 = 34;
            int num2 = 12;
            int num3 = 63;
            int num4 = 96;
            int num5 = 123;
            int num6 = 73;
            
            //2

            //a)
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

            //b)
            int product = num3 * num4;
            Console.WriteLine("The product of " + num3 + " and " + num4 + " is: " + product);

            //c)
            int remainder = num5 % num6;
            Console.WriteLine("The remainder of " + num5 + " and " + num6 + " is: " + remainder);

            //3
            Console.WriteLine("\nIncrement and Decrement operations on num6");

            Console.WriteLine("\nPostfix increment: num6 = " + num6++);
            Console.WriteLine("After Postfix Increment: num6 = " + num6);

            Console.WriteLine("\nPrefix increment: num6 = " + ++num6);

            Console.WriteLine("\nPostfix increment: num6 = " + num6--);
            Console.WriteLine("After Postfix Increment: num6 = " + num6);

            Console.WriteLine("\nPrefix increment: num6 = " + --num6);

            //4
            Console.WriteLine("\nOperators ");

            num5 += 146;
            Console.WriteLine("After += 146, num5 = " + num5);
            num5 -= 85;
            Console.WriteLine("After -= 85, num5 = " + num5);
            num5 *= 34; 
            Console.WriteLine("After *= 34, num5 = " + num5);
            num5 /= 53; 
            Console.WriteLine("After /= 53, num5 = " + num5);
            num5 %= 483;
            Console.WriteLine("After %= 483, num5 = " + num5);



            Console.ReadLine();
        }
    }
}
