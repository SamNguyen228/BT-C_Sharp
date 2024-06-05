using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập một loạt các số. Nhập 0 để kết thúc.");

        int sum = 0;
        while (true)
        {
            Console.Write("Nhập một số: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Đầu vào không hợp lệ! Vui lòng nhập một số hợp lệ.");
                continue;
            }

            if (number == 0)
            {
                break;
            }
            else if (number < 0)
            {
                Console.WriteLine("Các số âm sẽ được bỏ qua.");
                continue;
            }

            sum += number;
        }

        Console.WriteLine($"Tổng của các số dương đã nhập là: {sum}");
    }
}
