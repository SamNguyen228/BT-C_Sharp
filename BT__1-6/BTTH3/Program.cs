using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chuong trinh tinh tong cac so trong mang");

        // Nhập mảng số nguyên không dấu kích thước 2 byte
        Console.WriteLine("Nhap mang so nguyen khong dau (ushort)");
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n1 = int.Parse(Console.ReadLine());
        ushort[] unsignedArray = new ushort[n1];

        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            unsignedArray[i] = ushort.Parse(Console.ReadLine());
        }

        // Tính tổng mảng số nguyên không dấu
        ulong unsignedSum = 0;
        foreach (ushort num in unsignedArray)
        {
            unsignedSum += num;
        }
        Console.WriteLine($"Tong cua mang so nguyen khong dau la: {unsignedSum}");
        Console.WriteLine();
        // Nhập mảng số nguyên có dấu kích thước 2 byte
        Console.WriteLine("Nhap mang so nguyen co dau (short)");
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n2 = int.Parse(Console.ReadLine());
        short[] signedArray = new short[n2];

        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            signedArray[i] = short.Parse(Console.ReadLine());
        }

        // Tính tổng mảng số nguyên có dấu
        long signedSum = 0;
        foreach (short num in signedArray)
        {
            signedSum += num;
        }
        Console.WriteLine($"Tong cua mang so nguyen co dau la: {signedSum}");
        Console.ReadLine();
    }
}
