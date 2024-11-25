using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = num1;

            //2
            bool isTrue = true;
           
            //3
            // a)
            bool resultAnd = isTrue && (num1 > num3 && num2 > num4);
            Console.WriteLine($"Logical AND (isTrue && (num1 > num3 && num > num4)): \n{resultAnd}");
            //b
            bool resultOr = isTrue || (num1 < num3 || num2 > num4);
            Console.WriteLine($"Logical OR (isTrue && (num1 > num3 && num > num4)): \n{resultAnd}");
            //c
            bool resultNot = !isTrue;
            Console.WriteLine($"Logical NOT (!isTrue): \n{resultNot}");
            Console.WriteLine();
            //4
            //a)
            bool comparison1 = num1 > num3;
            Console.WriteLine($"Is num1 greater than num3? \n{comparison1}");
            //b)
            bool comparison2 = num2 < num4;
            Console.WriteLine($"Is num2 less than num4? \n{comparison2}");
            //c)
            bool comparison3 = num1 == num4;
            Console.WriteLine($"Is num1 equal to num4? \n{comparison3}");
            //d)
            bool comparison4 = num2 != num3;
            Console.WriteLine($"Is num2 equal to num3? \n{comparison4}");
            Console.WriteLine();

            //5
            //a)
            bool expression1 = (num1 > num3) && (num2 < num4);
            //b
            bool expression2 = (num1 < num3) || (num2 > num4);

            Console.WriteLine($"Expression1 ((num1 > num3) && (num2 < num4)): {expression1}");
            Console.WriteLine($"Expression2 ((num1 < num3) || (num2 > num4)): {expression2}");




            Console.ReadLine();
        }
    }
}
