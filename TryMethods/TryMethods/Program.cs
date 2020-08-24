using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, initials;
            Console.WriteLine("Hello!");

            firstName = GetUserInput("Enter your first name: ");
            lastName = GetUserInput("Enter your last name: ");

            fullName = GenerateFullName(firstName, lastName);
            initials = GenerateInitials(firstName, lastName);

            Console.WriteLine($"Your fullname is {fullName}, your initials is {initials}");
        }

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static string GenerateFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        
        static string GenerateInitials(string firstName, string lastName)
        {
            Console.WriteLine(firstName[0]);
            return $"{firstName[0]}{lastName[0]}";
        }
     }
}
