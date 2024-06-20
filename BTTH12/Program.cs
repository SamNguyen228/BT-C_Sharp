using System;
using System.Text;

class Program
{
    // Hàm để nhập số nguyên 2 byte không dấu từ bàn phím
    static ushort NhapSoNguyen2Byte()
    {
        ushort n;
        while (true)
        {
            Console.Write("Nhập số nguyên 2 byte không dấu (0 - 65535): ");
            string input = Console.ReadLine();
            if (ushort.TryParse(input, out n))
            {
                // Kiểm tra giá trị n có nằm trong khoảng hợp lệ không (0 - 65535)
                if (n >= 0 && n <= ushort.MaxValue)
                {
                    break;
                }
            }
            Console.WriteLine("Số nhập không hợp lệ. Vui lòng nhập lại.");
        }
        return n;
    }

    // Hàm tính tổng bình phương các số từ 1 đến n
    static ulong TinhTongBinhPhuong(ushort n)
    {
        ulong sumOfSquares = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sumOfSquares += (ulong)i * i;
        }
        return sumOfSquares;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Chọn chương trình:");
            Console.WriteLine("1. Nhập số nguyên 2 byte không dấu và in giá trị");
            Console.WriteLine("2. Tính tổng bình phương các số từ 1 đến n và in kết quả");
            Console.WriteLine("3. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            string choice = Console.ReadLine();
          
            switch (choice)
            {
                case "1":
                    ushort n = NhapSoNguyen2Byte();
                    Console.WriteLine($"Giá trị n được nhập là: {n}");
                    break;
                case "2":
                    ushort m = NhapSoNguyen2Byte();
                    ulong sum = TinhTongBinhPhuong(m);
                    Console.WriteLine($"Tổng bình phương các số từ 1 đến {m} là: {sum}");
                    break;
                case "3":
                    Console.WriteLine("\nNhấn phím bất kì để thoát chương trình.\n");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine(); // In một dòng trống để ngăn cách các lần lựa chọn
        }
    }
}
