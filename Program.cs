using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace uppgift18
{
    internal class Program
    {
        static int TriangleArea(int x, int y)
        {
            return x * y / 2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the triangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());  

            int area = TriangleArea(width, height);

            Console.WriteLine($"The area of the trianlge is: {area}");
            Console.ReadLine();
        }
        
        
    }
}
