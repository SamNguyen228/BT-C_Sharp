using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("******* Chương trình tìm giá trị lớn nhất *******");

        while (true)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("\n          Chọn loại dữ liệu để so sánh");
            Console.WriteLine("               1. Số nguyên");
            Console.WriteLine("               2. Số thực");
            Console.WriteLine("               3. Chuỗi");
            Console.WriteLine("               0. Thoát");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Nhập lựa chọn của bạn: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
            {
                Console.WriteLine("Vui lòng nhập lại lựa chọn hợp lệ.");
            }

            if (choice == 0)
            {
                break;
            }

            switch (choice)
            {
                case 1:
                    TestInteger();
                    break;
                case 2:
                    TestDouble();
                    break;
                case 3:
                    TestString();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        Console.WriteLine("\nKết thúc chương trình.");
    }

    static void TestInteger()
    {
        int a = 100;
        int b = 999;
        Console.WriteLine($"Số nguyên: {a}, {b}");
        Console.WriteLine($"Max là: {Max(a, b)}");
    }

    static void TestDouble()
    {
        double a = 7.9;
        double b = 12.4;
        Console.WriteLine($"Số thực: {a}, {b}");
        Console.WriteLine($"Max là: {Max(a, b)}");
    }

    static void TestString()
    {
        string a = "hello", b = "world";
        Console.WriteLine($"Chuỗi: \"{a}\", \"{b}\"");
        Console.WriteLine($"Max là: \"{Max(a, b)}\"");
    }

    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
}
