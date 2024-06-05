using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so nguyen: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number > 0)
                {
                    Console.WriteLine("Day la so nguyen duong.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Day la so nguyen am.");
                }
                else
                {
                    Console.WriteLine("Day la so 0.");
                }
            }
            Console.ReadLine();
        }
    }
}
