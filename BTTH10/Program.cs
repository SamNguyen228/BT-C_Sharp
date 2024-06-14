using System;
using System.Text;

struct SinhVien
{
    public string Ten;
    public double Diem;
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập n sv: ");
        int n = int.Parse(Console.ReadLine());

        SinhVien[] danhSachSinhVien = new SinhVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Sv {i + 1}:");
            Console.Write("Tên: ");
            string ten = Console.ReadLine();
            Console.Write("Điểm: ");
            double diem = double.Parse(Console.ReadLine());

            danhSachSinhVien[i].Ten = ten;
            danhSachSinhVien[i].Diem = diem;
        }

        Console.WriteLine("\nThông tin của các sinh viên:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Sinh viên {i + 1}:");
            Console.WriteLine($"Tên: {danhSachSinhVien[i].Ten}");
            Console.WriteLine($"Điểm: {danhSachSinhVien[i].Diem}");
            Console.WriteLine();
        }

        double diemTrungBinh = TinhDiemTrungBinh(danhSachSinhVien);
        Console.WriteLine($"Điểm trung bình của cả lớp: {diemTrungBinh}");

        Console.ReadLine();
    }

    static double TinhDiemTrungBinh(SinhVien[] danhSachSinhVien)
    {
        double tongDiem = 0;
        foreach (SinhVien sv in danhSachSinhVien)
        {
            tongDiem += sv.Diem;
        }
        return tongDiem / danhSachSinhVien.Length;
    }
}
