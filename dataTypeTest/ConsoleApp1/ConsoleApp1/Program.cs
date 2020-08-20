using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,,] cells;
            cells = new bool[2, 3, 3];
            Console.WriteLine(cells.GetLength(1));

            //string reverse, palindrome;
            //char[] temp;
            //System.Console.Write("Enter a palindrome: ");
            //palindrome = System.Console.ReadLine();
            //// Remove spaces and convert to lowercase
            //reverse = palindrome.Replace(" ", "");
            //reverse = reverse.ToLower();
            //// Convert to an array
            //temp = reverse.ToCharArray();
            //// Reverse the array
            //System.Array.Reverse(temp);
            //// Convert the array back to a string and
            //// check if reverse string is the same.
            //if (reverse == new string(temp))
            //{
            //    System.Console.WriteLine(
            //    $"\"{palindrome}\" is a palindrome.");
            //}
            //else
            //{
            //    System.Console.WriteLine(
            //    $"\"{palindrome}\" is NOT a palindrome.");
            //}

            string testNull = null;
            Console.WriteLine(testNull?.ToString());
            string testNotNull = "ABCD";
            Console.WriteLine(testNotNull?.ToLower());
        }

        public Boolean Test(Boolean input)
        {
            return true;
        }
    }
}
