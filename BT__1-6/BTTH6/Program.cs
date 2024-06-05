using System;

class Program
{
    static void Main(string[] args)
    {
        // a. Tính trung bình cộng của các số trong mảng
        double[] array = new double[8];

        // Nhập các phần tử của mảng từ người dùng
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Nhap cac phan tu cua mang so thuc:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        // Tính tổng các số trong mảng
        double sum = 0;
        foreach (double num in array)
        {
            sum += num;
        }

        // Tính trung bình cộng và in kết quả ra màn hình
        double average = sum / array.Length;
        Console.WriteLine($"Trung binh cong la: {average}");
        Console.WriteLine("----------------------------------");

        // b. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        double maxValue = array[0];
        double minValue = array[0];

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

        // In kết quả ra màn hình
        Console.WriteLine($"Max in Array: {maxValue}");
        Console.WriteLine($"Min in Array: {minValue}");

        Console.ReadLine();
    }
}
