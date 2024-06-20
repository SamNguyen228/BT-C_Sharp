using System;
using System.Text;

class Program
{
    static double ReadDouble()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Nhập lại. Đây không phải là một số thực hợp lệ.");
            Console.Write("Nhập số thực 8 byte: ");
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số thực 8 byte để tính căn bậc hai: ");
        double x = ReadDouble();

        // Tính căn bậc 2 của x
        double squareRoot = Math.Sqrt(x);

        Console.WriteLine($"Căn bậc 2 của số {x} là: {squareRoot}");
        Console.ReadLine();
    }
}
