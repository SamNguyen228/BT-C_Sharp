using System;
using System.Collections.Generic;
using System.Text;

    class Program
    {
        // Khai báo lớp SinhVien
        class SinhVien
        {
            public string Ten { get; set; }
            public string Lop { get; set; }
            public double Diem { get; set; }

            public SinhVien(string ten, string lop, double diem)
            {
                Ten = ten;
                Lop = lop;
                Diem = diem;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            int luaChon;

            do
            {
                Console.WriteLine("-------- Quản Lý Danh Sách Sinh Viên --------");
                Console.WriteLine("     1. Thêm sinh viên mới                  ");
                Console.WriteLine("     2. Hiển thị danh sách sinh viên        ");
                Console.WriteLine("     3. Tính tổng điểm của tất cả sinh viên ");
                Console.WriteLine("     4. Thoát                               ");
                Console.WriteLine("=============================================");
                Console.Write("Nhập lựa chọn của bạn: ");
                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien(danhSachSinhVien);
                        break;
                    case 2:
                        HienThiDanhSach(danhSachSinhVien);
                        break;
                    case 3:
                        TinhTongDiem(danhSachSinhVien);
                        break;
                    case 4:
                        Console.WriteLine("Exit!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (luaChon != 4);
        }

        static void ThemSinhVien(List<SinhVien> danhSach)
        {
            string ten, lop;
            double diem;

            do
            {
                Console.Write("Nhập tên sinh viên: ");
                ten = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ten))
                {
                    Console.WriteLine("Tên sinh viên không được để trống. Vui lòng nhập lại.");
                }
            } while (string.IsNullOrWhiteSpace(ten));

            do
            {
                Console.Write("Nhập lớp sinh viên: ");
                lop = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lop))
                {
                    Console.WriteLine("Lớp sinh viên không được để trống. Vui lòng nhập lại.");
                }
            } while (string.IsNullOrWhiteSpace(lop));

            do
            {
                Console.Write("Nhập điểm sinh viên: ");
                if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
                {
                    Console.WriteLine("Điểm không hợp lệ. Điểm phải là một số từ 0 đến 10. Vui lòng nhập lại.");
                }
            } while (diem < 0 || diem > 10);

            danhSach.Add(new SinhVien(ten, lop, diem));
            Console.WriteLine("\nThêm sinh viên thành công!\n");
        }

        static void HienThiDanhSach(List<SinhVien> danhSach)
        {
            
            Console.WriteLine("----- Danh Sách Sinh Viên -----");
            foreach (SinhVien sv in danhSach)
            {
                Console.WriteLine($"\nTên: {sv.Ten}, Lớp: {sv.Lop}, Điểm: {sv.Diem}\n");
        }
        }

        static void TinhTongDiem(List<SinhVien> danhSach)
        {
            double tongDiem = 0;
            foreach (SinhVien sv in danhSach)
            {
                tongDiem += sv.Diem;
            }
            Console.WriteLine($"\nTổng điểm của tất cả sinh viên: {tongDiem}\n");
        }
    }
