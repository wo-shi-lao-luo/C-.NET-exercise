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
        }
    }
}
