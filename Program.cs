using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many time do you want to loop?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0) 
            {
                Console.WriteLine("Enter a value above 0! ");
            }
            else 
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(i);
                }
            }
           
            Console.Write("Loop Finished! ");
            Console.ReadLine();
        }
    }
}
