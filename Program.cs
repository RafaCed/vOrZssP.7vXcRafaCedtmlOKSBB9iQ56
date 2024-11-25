using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // run this py code first for a better experience!
            /*
             import random


print('Password Generator')


chars = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()-_+=,:;?./0123456789'

number = input('Amount of passwords to generate: ')
number = int(number)

length = 0

while length < 16:
    length = input('Length of password (must be at least 16): ')
    length = int(length)
    if length < 16:
        print("Length must be at least 16 characters. Please try again.")
print()
print('Here are some passwords: ')
print()
for pwd in range(number):
    passwords = ''
    for c in range(length):
        passwords += random.choice(chars)

    print(passwords)    

    print()
            */
            Console.WriteLine("Please enter a password: ");
            string pwd1 = Console.ReadLine();

            Console.WriteLine("Please enter password again: ");
            string pwd2 = Console.ReadLine();

            if (string.IsNullOrEmpty(pwd1) || string.IsNullOrEmpty(pwd2))
            {
                Console.WriteLine("Password can't be empty and must contain atleast 16 characters. ");
            }
            else if (pwd1.Length < 16 || pwd2.Length < 16)
            {
                Console.WriteLine("Password must be atleast 16 characters long. ");
            }
            else if (pwd1 == pwd2)
            {
                Console.WriteLine("Correct Password. ");
            }
            else 
            {
                Console.WriteLine("Incorrect Password. ");
            }

            Console.ReadLine();
        }
    }
}
