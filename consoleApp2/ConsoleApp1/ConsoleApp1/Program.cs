using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string welcome = "KY C#";
        public static int partNum;
        static void Main(string[] args)
        {
            partNum = 2;
            var message = string.Format("Welcome to {0} Part {1}", welcome, partNum);
            Console.WriteLine(message);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
