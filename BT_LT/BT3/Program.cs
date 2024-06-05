using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so nguyen duong: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            {
                int factorial = 1; 
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($" {num}! = {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
