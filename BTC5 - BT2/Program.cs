using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Dictionary<string, string> tuDien = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase); // Sử dụng StringComparer.OrdinalIgnoreCase để không phân biệt chữ hoa chữ thường
        int Choice;

        tuDien.Add("Hello", "Xin Chào");
        tuDien.Add("Goodbye", "Tạm Biệt");
        tuDien.Add("thank you", "Cảm Ơn");
        tuDien.Add("sorry", "Xin Lỗi");
        tuDien.Add("yes", "Vâng");
        tuDien.Add("no", "Không");

        do
        {
            Console.WriteLine("**********-- Dictionary --**********");
            Console.WriteLine("*          1. Thêm từ mới          *");
            Console.WriteLine("*          2. Tra từ               *");
            Console.WriteLine("*          3. Thoát                *");
            Console.WriteLine("************************************");
            Console.WriteLine("====================================");
            Console.Write("Nhập lựa chọn của bạn: ");
            if (!int.TryParse(Console.ReadLine(), out Choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại!");
                continue;
            }

            switch (Choice)
            {
                case 1:
                    ThemTuMoi(tuDien);
                    break;
                case 2:
                    TraTu(tuDien);
                    break;
                case 3:
                    Console.WriteLine("Exit!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn lại!");
                    break;
            }
        } while (Choice != 3);
    }

    static void ThemTuMoi(Dictionary<string, string> tuDien)
    {
        Console.WriteLine("======= Thêm Từ Vào Từ Điển =======");
        string tuTiengAnh, nghiaTiengViet;

        do
        {
            Console.Write("Nhập từ tiếng Anh: ");
            tuTiengAnh = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tuTiengAnh))
            {
                Console.WriteLine("\nTừ tiếng Anh không được để trống!\n");
                continue;
            }
            if (!Regex.IsMatch(tuTiengAnh, @"^[a-zA-Z\s]+$")) // Cho phép cả dấu cách để nhập các cụm từ
            {
                Console.WriteLine("\nTừ tiếng Anh chỉ được chứa các ký tự chữ cái!\n");
                continue;
            }
            break;
        } while (true);

        do
        {
            Console.Write("Nhập nghĩa tiếng Việt: ");
            nghiaTiengViet = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nghiaTiengViet))
            {
                Console.WriteLine("\nNghĩa tiếng Việt không được để trống!\n");
            }
        } while (string.IsNullOrWhiteSpace(nghiaTiengViet));

        string key = tuTiengAnh.ToLower(); // Chuyển đổi về dạng chữ thường để lưu vào từ điển
        if (tuDien.ContainsKey(key))
        {
            Console.WriteLine("\nTừ này đã tồn tại trong từ điển!\n");
        }
        else
        {
            tuDien.Add(key, nghiaTiengViet);
            Console.WriteLine("\nThêm từ mới thành công!\n");
        }
    }

    static void TraTu(Dictionary<string, string> tuDien)
    {
        Console.WriteLine("======= Tra Từ Điển =======");
        string tuCanTra;

        do
        {
            Console.Write("Nhập từ tiếng Anh cần tra: ");
            tuCanTra = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tuCanTra))
            {
                Console.WriteLine("\nTừ tiếng Anh cần tra không được để trống!\n");
                continue;
            }
            if (!Regex.IsMatch(tuCanTra, @"^[a-zA-Z\s]+$")) // Cho phép cả dấu cách để nhập các cụm từ
            {
                Console.WriteLine("\nTừ tiếng Anh chỉ được chứa các ký tự chữ cái!\n");
                continue;
            }
            break;
        } while (true);

        string key = tuCanTra.ToLower(); // Chuyển đổi về dạng chữ thường để tra từ điển
        if (tuDien.TryGetValue(key, out string nghiaTiengViet))
        {
            Console.WriteLine($"\nNghĩa tiếng Việt của '{tuCanTra}' là: {nghiaTiengViet}\n");
        }
        else
        {
            Console.WriteLine($"\nKhông tìm thấy nghĩa của từ '{tuCanTra}' trong từ điển!\n");
        }
    }
}
