using System;
using System.Text;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn 1 lựa chọn! ");
            Console.WriteLine("a. Đảo ngược chuỗi");
            Console.WriteLine("b. Đếm số lượng từ trong chuỗi");
            Console.WriteLine("c. Thoát");

            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "a":
                    DaoNguocChuoi();
                    break;
                case "b":
                    DemTuTrongChuoi();
                    break;
                case "c":
                    Console.WriteLine("Tạm biệt!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine("\nNhấn Enter để tiếp tục...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void DaoNguocChuoi()
    {
        Console.Write("Nhập chuỗi kí tự: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
    }

    static void DemTuTrongChuoi()
    {
        Console.Write("Nhập chuỗi kí tự: ");
        string input = Console.ReadLine();

        int wordCount = 0;
        bool inWord = false;

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else if (!inWord)
            {
                wordCount++;
                inWord = true;
            }
        }

        Console.WriteLine("Số lượng từ trong chuỗi: " + wordCount);
    }
}
