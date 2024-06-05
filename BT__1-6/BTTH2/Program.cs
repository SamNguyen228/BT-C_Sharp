using System;

namespace BTTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("            -----------------------------------------------");
            Console.WriteLine("1. Tim so lon nhat va so be nhat trong mot mang cac so nguyen 1 byte co dau");
            Console.WriteLine("2. Tinh tong cac so chan trong mot mang cac so nguyen 1 byte co dau");
            Console.WriteLine("3. Tinh tong cac so tu 1 đen n (n la so nguyen 1 byte khong dau)");
            Console.WriteLine("4. Tinh tong cac chu so trong mot so nguyen 1 byte khong dau");
            Console.WriteLine("            *_____________________________________________*");
            Console.Write("Input Your Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindMinMax();
                    break;
                case 2:
                    CalculateEvenSum();
                    break;
                case 3:
                    CalculateNumberSum();
                    break;
                case 4:
                    CalculateDigitSum();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void FindMinMax()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            sbyte[] arr = new sbyte[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i + 1}: ");
                arr[i] = sbyte.Parse(Console.ReadLine());
            }

            sbyte min = arr[0];
            sbyte max = arr[0];

            foreach (sbyte num in arr)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine($"So be nhat trong mang: {min}");
            Console.WriteLine($"So lon nhat trong mang: {max}");
        }

        static void CalculateEvenSum()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            sbyte[] arr = new sbyte[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i + 1}: ");
                arr[i] = sbyte.Parse(Console.ReadLine());
            }

            int evenSum = 0;
            foreach (sbyte num in arr)
            {
                if (num % 2 == 0)
                    evenSum += num;
            }
            Console.WriteLine($"Tong cac so chan trong mang: {evenSum}");
        }

        static void CalculateNumberSum()
        {
            Console.Write("Nhap so nguyen n: ");
            byte n = byte.Parse(Console.ReadLine());
            uint sum = 0;
            for (byte i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Tong cac so tu 1 den {n}: {sum}");
        }

        static void CalculateDigitSum()
        {
            Console.Write("Nhap mot so nguyen 1 byte khong dau: ");
            byte n = byte.Parse(Console.ReadLine());
            byte digitSum = 0;
            while (n > 0)
            {
                digitSum += (byte)(n % 10);
                n /= 10;
            }
            Console.WriteLine($"Tong cac chu so trong so: {digitSum}");
        }
    }
}