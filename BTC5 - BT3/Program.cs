using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Beep();
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        ArrayList danhSachSanPham = new ArrayList();
        int choice;

        do
        {
            Console.WriteLine("******* Quản lý danh sách sản phẩm *******");
            Console.WriteLine("      1. Thêm sản phẩm mới");
            Console.WriteLine("      2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("      3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("      4. Thoát ");
            Console.WriteLine("==========================================");
            Console.Write("Nhập lựa chọn của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ThemSanPham(danhSachSanPham);
                    break;
                case 2:
                    HienThiDanhSachSanPham(danhSachSanPham);
                    break;
                case 3:
                    TimKiemSanPham(danhSachSanPham);
                    break;
                case 4:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                    break;
            }

        } while (choice != 4);
    }

    static void ThemSanPham(ArrayList danhSachSanPham)
    {
        Console.WriteLine("\n======= Thêm sản phẩm mới =======");
        Console.Write("Nhập tên sản phẩm: ");
        string tenSanPham = Console.ReadLine();
        Console.Write("Nhập mô tả sản phẩm: ");
        string moTaSanPham = Console.ReadLine();
        Console.Write("Nhập giá sản phẩm: ");
        double giaSanPham;

        while (!double.TryParse(Console.ReadLine(), out giaSanPham) || giaSanPham < 0)
        {
            Console.WriteLine("Giá sản phẩm không hợp lệ! Vui lòng nhập lại.");
            Console.Write("Nhập giá sản phẩm: ");
        }

        SanPham sp = new SanPham(tenSanPham, moTaSanPham, giaSanPham);
        danhSachSanPham.Add(sp);
        Console.WriteLine("\nThêm sản phẩm mới thành công!\n");
    }

    static void HienThiDanhSachSanPham(ArrayList danhSachSanPham)
    {
        Console.WriteLine("\n======= Danh sách sản phẩm =======");
        if (danhSachSanPham.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm hiện đang trống.");
        }
        else
        {
            int count = 1;
            foreach (SanPham sp in danhSachSanPham)
            {
                Console.WriteLine($"Sản phẩm {count++}:");
                sp.HienThiThongTin();
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine();
    }

    static void TimKiemSanPham(ArrayList danhSachSanPham)
    {
        Console.WriteLine("\n======= Tìm kiếm sản phẩm theo tên =======");
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string tenTimKiem = Console.ReadLine().Trim().ToLower();

        bool timThay = false;
        foreach (SanPham sp in danhSachSanPham)
        {
            if (sp.Ten.ToLower().Contains(tenTimKiem))
            {
                sp.HienThiThongTin();
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine($"Không tìm thấy sản phẩm có tên chứa '{tenTimKiem}'.");
        }
        Console.WriteLine();
    }
}

class SanPham
{
    public string Ten { get; set; }
    public string MoTa { get; set; }
    public double Gia { get; set; }

    public SanPham(string ten, string moTa, double gia)
    {
        Ten = ten;
        MoTa = moTa;
        Gia = gia;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Tên: {Ten}");
        Console.WriteLine($"Mô tả: {MoTa}");
        Console.WriteLine($"Giá: {Gia}");
    }
}
