///// BTTH 49 //////
////////////////////
//using System;
//using System.Text;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.InputEncoding = Encoding.UTF8;
//        Console.OutputEncoding = Encoding.UTF8;

//        // Khai báo các mảng dữ liệu
//        int[] intArray = { -5, 3, 8, -2, 4 };
//        uint[] uintArray = { 5, 3, 8, 2, 4 };
//        float[] floatArray = { 12.5f, 3.11f, 8.1f, 2.6f, 4.2f };
//        double[] doubleArray = { 5.4, 3.0, 8.6, 2.23, 4.52 };

//        // Khai báo biến dynamic
//        dynamic min_value;

//        // Gọi hàm với mảng số nguyên 4 byte
//        min_value = FindMin<int>(intArray);
//        Console.WriteLine($"GTNN trong mảng intArray: {min_value.ToString()}"); // GTTN = Giá Trị Nhỏ Nhất 

//        // Gọi hàm với mảng số nguyên 4 byte không dấu
//        min_value = FindMin<uint>(uintArray);
//        Console.WriteLine($"GTNN trong mảng uintArray: {min_value.ToString()}");

//        // Gọi hàm với mảng số thực 4 byte
//        min_value = FindMin<float>(floatArray);
//        Console.WriteLine($"GTNN trong mảng floatArray: {min_value.ToString()}");

//        // Gọi hàm với mảng số thực 8 byte
//        min_value = FindMin<double>(doubleArray);
//        Console.WriteLine($"GTNN trong mảng doubleArray: {min_value.ToString()}");
//    }

//    // Hàm generic để tìm giá trị nhỏ nhất trong mảng
//    static T FindMin<T>(T[] array) where T : IComparable<T>
//    {
//        if (array == null || array.Length == 0)
//        {
//            throw new ArgumentException("Mảng không được rỗng hoặc null");
//        }

//        T min = array[0];

//        foreach (T item in array)
//        {
//            if (item.CompareTo(min) < 0)
//            {
//                min = item;
//            }
//        }

//        return min;
//    }
//}

//////// BTTH50 ///////
///////////////////////
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo các mảng dữ liệu
        int[] intArray = { -5, 3, 8, -2, 4 };
        uint[] uintArray = { 5, 3, 8, 2, 4 };
        float[] floatArray = { 12.5f, 3.11f, 8.1f, 2.6f, 4.2f };
        double[] doubleArray = { 5.4, 3.0, 8.6, 2.23, 4.52 };

        // Khai báo biến dynamic
        dynamic min_value;

        // Gọi hàm với mảng số nguyên 4 byte
        min_value = FindMin(intArray);
        Console.WriteLine($"GTNN trong mảng intArray: {min_value.ToString()}"); // GTTN = Giá Trị Nhỏ Nhất 

        // Gọi hàm với mảng số nguyên 4 byte không dấu
        min_value = FindMin(uintArray);
        Console.WriteLine($"GTNN trong mảng uintArray: {min_value.ToString()}");

        // Gọi hàm với mảng số thực 4 byte
        min_value = FindMin(floatArray);
        Console.WriteLine($"GTNN trong mảng floatArray: {min_value.ToString()}");

        // Gọi hàm với mảng số thực 8 byte
        min_value = FindMin(doubleArray);
        Console.WriteLine($"GTNN trong mảng doubleArray: {min_value.ToString()}");
    }

    // Hàm generic để tìm giá trị nhỏ nhất trong mảng
    static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng hoặc null");
        }

        T min = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }

        return min;
    }
}

