using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNum = {45, 12, 78, 34, 89, 23};
            Console.WriteLine("Original list: ");
            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }
            
            Console.WriteLine("\nSorted list: ");
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nSorted list in reverse: ");
            
            for (int i = myNum.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myNum[i]);
            }
            List<int> numList = new List<int>(myNum); 
            numList.Remove(78); 

            myNum = numList.ToArray();

            Console.WriteLine("\nArray after removing 78:");
            foreach (int num in myNum)
            {
                Console.WriteLine(num);
            }
            int index = Array.IndexOf(myNum, 34);
            if (index != -1)
            {
                Console.WriteLine($"\nThe index of 34 is: {index}");
            }
            else
            {
                Console.WriteLine("\nThe number 34 doesn't exist in the array");
            }

            Console.ReadLine();
        }
    }
}
