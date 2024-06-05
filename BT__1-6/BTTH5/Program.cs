using System;

class Program
{
    static void Main(string[] args)
    {
        // a. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        float[] array = new float[4];

        // Nhập các phần tử của mảng từ người dùng
        Console.WriteLine("Nhap vao cac phan tu cua mang so thuc.");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            array[i] = float.Parse(Console.ReadLine());
        }

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        float maxValue = array[0];
        float minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        // In kết quả ra màn hình với định dạng số thực
        Console.WriteLine($"Max in Array: {maxValue.ToString("F2")}");
        Console.WriteLine($"Min in Array: {minValue.ToString("F2")}");

        // b. Tính tổng các số trong mảng
        float sum = 0;
        foreach (float num in array)
        {
            sum += num;
        }

        // In tổng ra màn hình
        Console.WriteLine($"Tong cac so trong mang la: {sum.ToString("F2")}");

        Console.ReadLine();
    }
}
