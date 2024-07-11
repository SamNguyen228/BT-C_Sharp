using System;
using System.Collections.Generic;
using System.Text;

class SinhVien
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        Dictionary<string, double> dict1 = new Dictionary<string, double>();

        while (true)
        {
            Console.Write("Nhập mã sinh viên (nhập '#' để dừng): ");
            string id = Console.ReadLine();
            if (id == "#")
            {
                break;
            }

            Console.Write("Nhập điểm trung bình (GPA): ");
            string gpaInput = Console.ReadLine();
            if (!double.TryParse(gpaInput, out double gpa))
            {
                Console.WriteLine("Điểm trung bình không hợp lệ. Bỏ qua sinh viên này.");
                continue;
            }

            danhSachSinhVien.Add(new SinhVien { ID = id, GPA = gpa });
        }

        // Thêm các sinh viên vào từ điển
        foreach (var sinhVien in danhSachSinhVien)
        {
            dict1[sinhVien.ID] = sinhVien.GPA;
        }

        // Tìm điểm trung bình của sinh viên có ID "123456"
        if (dict1.TryGetValue("123456", out double gpaValue))
        {
            Console.WriteLine("Điểm trung bình của sinh viên có ID '123456' là: " + gpaValue);
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có ID '123456'.");
        }
    }
}
