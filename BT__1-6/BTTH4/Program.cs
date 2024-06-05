using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Phần a: Kiểm tra số Palindrome
        Console.Write("Nhap so nguyen khong dau kich thuoc 8 byte: ");
        ulong number;
        if (ulong.TryParse(Console.ReadLine(), out number))
        {
            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} la so Palindrome.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so Palindrome.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("INVALID Input.");
        }

        // Phần b: Tính tổng của mảng số nguyên có dấu kích thước 8 byte
        while (true)
        {
            Console.Write("Nhap cac so nguyen co dau co kich thuoc 8 byte: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    long[] array = input.Split(' ').Select(long.Parse).ToArray();
                    long sum = array.Sum();
                    Console.WriteLine($"Tong cua cac so trong mang la: {sum}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("INVALID. Input Again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Mot hoac nhieu so nhap vao vuot qua gioi han cho phep. Input Again.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("INVALID. Input Again.");
                Console.ReadLine();
            }
        }
    }

    static bool IsPalindrome(ulong number)
    {
        string str = number.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return str == new string(charArray);
    }
}