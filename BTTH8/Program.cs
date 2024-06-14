using System;
using System.Text;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn chương trình cần chạy:");
            Console.WriteLine("a. Hiển thị bảng mã ASCII");
            Console.WriteLine("b. Hiển thị bảng mã UTF-8 của trang mã 65001");
            Console.WriteLine("c. Phát tiếng beep khi nhấn phím space");
            Console.WriteLine("d. Đếm số lần xuất hiện của mỗi ký tự trong chuỗi");
            Console.WriteLine("e. Thoát");

            Console.Write("Nhập lựa chọn (a/b/c/d/e): ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "a":
                    DisplayASCIITable();
                    break;
                case "b":
                    DisplayUTF8Table();
                    break;
                case "c":
                    PlayBeepOnSpacePress();
                    break;
                case "d":
                    CountCharactersInString();
                    break;
                case "e":
                    Console.WriteLine("Tạm biệt!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void DisplayASCIITable()
    {
        Console.WriteLine("Bảng mã ASCII:");
        Console.WriteLine("   Decimal   Hex   Char");
        Console.WriteLine("   -------   ---   ----");

        for (int i = 0; i <= 127; i++)
        {
            char c = (char)i;
            Console.WriteLine($"   {i,8}   {i:X2}   {c}");
        }
    }

    static void DisplayUTF8Table()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Bảng mã UTF-8 của trang mã 65001:");
        Console.WriteLine("   Decimal   Hex   Char");
        Console.WriteLine("   -------   ---   ----");

        for (int i = 0; i <= 255; i++)
        {
            char c = (char)i;
            Console.WriteLine($"   {i,8}   {i:X2}   {c}");
        }
    }

    static void PlayBeepOnSpacePress()
    {
        Console.WriteLine("Phát tiếng beep khi nhấn phím space:");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
        }
    }

    static void CountCharactersInString()
    {
        Console.WriteLine("Đếm số lần xuất hiện của mỗi ký tự trong chuỗi:");
        Console.Write("Nhập chuỗi ký tự: ");
        string input = Console.ReadLine();

        var charCount = new int[256];

        foreach (char c in input)
        {
            charCount[(int)c]++;
        }

        Console.WriteLine("\nSố lần xuất hiện của mỗi ký tự:");
        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] > 0)
            {
                Console.WriteLine($"{(char)i}: {charCount[i]}");
            }
        }
    }
}