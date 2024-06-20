using System;
using System.Text;

class Program
{
    // Hàm static đếm số từ trong xâu ký tự
    public static int CountWords(string input)
    {
        // Tách các từ bằng các ký tự không phải là chữ cái hoặc số
        char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '_', '/' };
        // Tách từ và đếm số từ khác rỗng
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập xâu ký tự từ bàn phím
        Console.Write("Nhập xâu ký tự: ");
        string st = Console.ReadLine();

        // Nếu xâu ký tự là "#", phát tiếng beep
        if (st == "#")
        {
            Console.Beep();
        }
        else
        {
            // Gọi hàm để đếm và in ra số từ của xâu ký tự
            int wordCount = CountWords(st);
            Console.WriteLine("Số từ trong xâu ký tự là: " + wordCount);
            Console.ReadLine();
        }
    }
}
