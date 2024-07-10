using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo danh sách listf các số thực 4 byte
        List<float> listf = new List<float> { 5.0f, 3.0f, 9.0f, 1.0f };

        // Bổ sung vào cuối danh sách các số thực
        listf.Add(3.5f);
        listf.Add(-1.2f);
        listf.Add(7.8f);
        listf.Add(-5.0f);

        // Duyệt danh sách theo chỉ số để hiển thị các phần tử
        Console.WriteLine("Danh sách các số thực sau khi bổ sung:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        listf.Sort();

        // Hiển thị danh sách sau khi sắp xếp
        Console.WriteLine("\nDanh sách các số thực sau khi sắp xếp tăng dần:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }
    }
}
