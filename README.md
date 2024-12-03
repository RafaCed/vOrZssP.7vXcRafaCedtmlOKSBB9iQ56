# c-sharp

namespace uppgift21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your age: ");   //error
            string ageInput = Console.ReadLine();  //error
            int age = Convert.ToInt32(ageInput);  //error

            if (age > 18)
            {
                Console.WriteLine("Over 18 ");
            }
            else if (age > 30) 
            {
                Console.WriteLine("Over 30 ");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50 ");
            }
            else if (age < 18)
            {
                Console.WriteLine("Under 18 "); // extra if under 18
            }

            Console.ReadLine();
        }
    }
}
