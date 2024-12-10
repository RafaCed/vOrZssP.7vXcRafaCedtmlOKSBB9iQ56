# c-sharp

namespace LogicalError1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, 30, 25 };
            int max = 0;  //<-- int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < max)   //<-- if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum value in the array is: {max}");
   /* or using linq
   usgin System.Linq;
   int[] numbers = {10, 20, 5, 30, 25};

   int max = numbers.Max();

   Console.WriteLine($"The max value in the array is: {max}");  */


            Console.ReadLine();
        }
    }
}
