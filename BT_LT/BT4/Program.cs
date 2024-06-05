using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot: ");
            int column = int.Parse((string)Console.ReadLine());

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < column; j++) 
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
