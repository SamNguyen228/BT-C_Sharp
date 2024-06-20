using System;
using System.Text;

class Program
{
    // Hàm đọc số nguyên 1 byte từ bàn phím, yêu cầu nằm trong khoảng 2 đến 10.
    static byte ReadByteInputInRange(string prompt, byte min, byte max)
    {
        byte input;
        while (true)
        {
            Console.Write(prompt);
            if (byte.TryParse(Console.ReadLine(), out input))
            {
                if (input >= min && input <= max)
                    return input;
                else
                    Console.WriteLine($"Vui lòng nhập số từ {min} đến {max}.");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương từ 2 đến 10.");
            }
        }
    }

    // Hàm đọc số nguyên 4 byte từ bàn phím.
    static int ReadIntInput(string prompt)
    {
        int input;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên.");
            }
        }
    }

    // Hàm nhập vào mảng 2 chiều số nguyên 4 byte.
    static int[,] Input2DIntArray(int m, int n)
    {
        int[,] array = new int[m, n];
        Console.WriteLine($"Nhập các phần tử của mảng [{m}][{n}]:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = ReadIntInput($"Nhập phần tử [{i}][{j}]: ");
            }
        }
        return array;
    }

    // Hàm tính tổng các phần tử của mảng chia hết cho 2024.
    static long SumOfMultiplesOf2024(int[,] array, int m, int n)
    {
        long sum = 0;
        const int p = 2024;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] % p == 0)
                {
                    sum += array[i, j];
                }
            }
        }

        return sum;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập và hiển thị giá trị của m và n (1 byte không dấu)
        byte m = ReadByteInputInRange("Nhập giá trị của m (2 đến 10): ", 2, 10);
        byte n = ReadByteInputInRange("Nhập giá trị của n (2 đến 10): ", 2, 10);
        Console.WriteLine($"Bạn đã nhập m = {m}, n = {n}");

        // Khai báo và nhập giá trị các phần tử của mảng a
        int[,] a = Input2DIntArray(m, n);

        // In ra màn hình giá trị của mảng a đã nhập
        Console.WriteLine("Các phần tử của mảng a:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[i, j]} ");
            }
            Console.WriteLine();
        }

        // Tính tổng các phần tử của mảng chia hết cho 2024
        long sum = SumOfMultiplesOf2024(a, m, n);
        Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {sum}");
    }
}
