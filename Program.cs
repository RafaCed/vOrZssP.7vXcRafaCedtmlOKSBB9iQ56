using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.Write("Please enter the original price of the product: ");
            string priceInput = Console.ReadLine();


           

            if (!double.TryParse(priceInput, out double originalPrice) || originalPrice <= 0)
           
            {
                Console.WriteLine("Invalid price. Please enter a positive number.");
                return; 
                
            }



            Console.Write("Please enter the discount type (student, senior, none): ");
            string discountType = Console.ReadLine().ToLower();
            double discountPercentage;
            switch (discountType)

            {

                case "student":

                    discountPercentage = 0.15;

                    break;

                case "senior":

                    discountPercentage = 0.20;

                    break;

                case "none":

                    discountPercentage = 0.00;

                    break;

                default:

                    Console.WriteLine("Invalid discount type! Please enter 'student', 'senior', or 'none'.");

                    return; 
            }

            double discountAmount = originalPrice * discountPercentage;
            double finalPrice = originalPrice - discountAmount;

            Console.WriteLine($"Original Price: ${originalPrice:F2}");

            Console.WriteLine($"Discount Type: {char.ToUpper(discountType[0]) + discountType.Substring(1)}");

            Console.WriteLine($"Discount Amount: ${discountAmount:F2}");

            Console.WriteLine($"Final Price: ${finalPrice:F2}");

            if (finalPrice < 50)

            {

                Console.WriteLine("This is a great deal!");

            }
        }
    }
}
