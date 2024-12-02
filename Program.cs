using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>();
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Add a new subject: ");
                Console.WriteLine("2. Remove a subject: ");
                Console.WriteLine("3. Show all: ");
                Console.WriteLine("4. Exit. ");
                Console.Write("Select and option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSubject(subjects);
                        break;
                    case "2":
                        RemoveSubject(subjects);
                        break;
                    case "3":
                        DisplaySubjects(subjects);
                        break;
                    case "4":
                        exitProgram = true;
                        Console.WriteLine("Exiting program. ");
                        break;
                    default:
                        Console.WriteLine("Invalid option. ");
                        break;

                }
                Console.WriteLine();
            }
        }
        //
        static void AddSubject(Dictionary<string, string> subjects)
        {
            Console.Write("Enter name of the new subject: ");
            string subjectName = Console.ReadLine();
            Console.Write("Enter name of the teacher: ");
            string teacherName = Console.ReadLine();
            
            if (!subjects.ContainsKey(subjectName))
            {
                subjects.Add(subjectName, teacherName);
                Console.WriteLine("Subject added successfully. ");
            }
            else
            {
                Console.WriteLine("Subject already exists. ");
            }
        }
        //
        static void RemoveSubject(Dictionary<string, string> subjects)
        {
            string subjectName = Console.ReadLine();
            if (subjects.ContainsKey(subjectName))
            {
                subjects.Remove(subjectName);
                Console.WriteLine("Subject removed successfully");
            }
            else
            {
                Console.WriteLine("Subject not found. ");
            }
        }
        //
        static void DisplaySubjects(Dictionary<string, string> subjects)
        {
            Console.WriteLine("Subjects and Teachers: ");
            if (subjects.Count == 0)
            {
                Console.WriteLine("No subjects avaible. ");
            }
            else
            {
                foreach (var kvp in subjects)
                {
                    Console.WriteLine($"Subject: {kvp.Key}, Teacher: {kvp.Value}"); //kvp=keyValuePair
                }
            }
        }
    }
}


       
