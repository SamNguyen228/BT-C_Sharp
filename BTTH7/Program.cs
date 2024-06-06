using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("------------------ Chọn một tùy chọn: -------------------");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*    1. Tính tổng 2 số nguyên không dấu                 *");
            Console.WriteLine("*    2. Tính diện tích và chu vi hình chữ nhật          *");
            Console.WriteLine("*    3. Kiểm tra chẵn lẻ                                *");
            Console.WriteLine("*    4. Tính tổng 2 số nguyên có dấu (1 byte)           *");
            Console.WriteLine("*    5. Tính tổng các số từ 1 đến n                     *");
            Console.WriteLine("*    6. Tính diện tích và chu vi hình chữ nhật (8 byte) *");
            Console.WriteLine("*    7. Tìm số lớn nhất                                 *");
            Console.WriteLine("*    8. Tính giai thừa                                  *");
            Console.WriteLine("*    9. Kiểm tra số nguyên tố                           *");
            Console.WriteLine("*    10. Kiểm tra số hoàn hảo                           *");
            Console.WriteLine("*    11. Thoát                                          *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*********************************************************");

            Console.Write("Nhập Lựa Chọn Của Bạn: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    TinhTongKhongDau();
                    break;
                case "2":
                    TinhDienTichVaChuVi();
                    break;
                case "3":
                    KiemTraChanLe();
                    break;
                case "4":
                    TinhTongCoDau();
                    break;
                case "5":
                    Tong1toN();
                    break;
                case "6":
                    TinhDienTichVaChuVi8Byte();
                    break;
                case "7":
                    TimSoLonNhat();
                    break;
                case "8":
                    TinhGiaiThua();
                    break;
                case "9":
                    KiemTraSoNT();
                    break;
                case "10":
                    KiemTraSoHoanHao();
                    break;
                case "11":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ ! Vui lòng nhập lại.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nNhấn vào bất kỳ để quay lại menu...");
                Console.ReadKey();
            }
        } while (!exit);
    }

    static void TinhTongKhongDau()
    {
        Console.Write("Nhập a: ");
        uint a = uint.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        uint b = uint.Parse(Console.ReadLine());

        uint sum = a + b;
        Console.WriteLine($"Tổng của {a} và {b} là: {sum}");
       
    }

    static void TinhDienTichVaChuVi()
    {
        Console.Write("Nhập Chiều Dài: ");
        ushort cd = ushort.Parse(Console.ReadLine());

        Console.Write("Nhập Chiều Rộng: ");
        ushort cr = ushort.Parse(Console.ReadLine());

        ushort chuvi = (ushort)((cd + cr) * 2);
        ushort dientich = (ushort)(cd * cr);

        Console.WriteLine($"Chu vi là: {chuvi}");
        Console.WriteLine($"Diện tích là: {dientich}");
    }


    static void KiemTraChanLe() 
    {
        Console.Write("Nhập một số: ");
        uint number = uint.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"Số {number} là số chẵn.");
        }
        else 
        {
            Console.WriteLine($"Số {number} là số lẻ.");
        }
    }
    static void TinhTongCoDau()
    {
        // Nhận đầu vào từ người dùng
        Console.Write("Nhập a (1byte): ");
        sbyte a = sbyte.Parse(Console.ReadLine());

        Console.Write("Nhập b (1byte): ");
        sbyte b = sbyte.Parse(Console.ReadLine());

        try
        {
            // Tính tổng
            sbyte sum = (sbyte)(a + b);

            // In kết quả
            Console.WriteLine($"Tổng của hai số là: {sum}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Tổng của hai số vượt quá phạm vi của kiểu dữ liệu 1byte!");
        }
    }

static void Tong1toN()
    {
        Console.Write("Nhập số n: ");
        uint n = uint.Parse(Console.ReadLine());

        uint sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
    }

    static void TinhDienTichVaChuVi8Byte()
    {
        Console.Write("Nhập chiều dài: ");
        ulong cd = ulong.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        ulong cr = ulong.Parse(Console.ReadLine());

        ulong dientich = cr * cd;
        ulong chuvi = (cr + cd) * 2;

        Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");
        Console.WriteLine($"Chu vi hình chữ nhật là: {chuvi}");
    }

    static void TimSoLonNhat()
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhập c: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(Math.Max(a, b), c);
        Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
    }

    static void TinhGiaiThua()
    {
        Console.Write("Nhập số n: ");
        uint n = uint.Parse(Console.ReadLine());

        uint giaithua = 1;
        for (uint i = 2; i <= n; i++)
        {
            giaithua *= i;
        }

        Console.WriteLine($" {n}! = {giaithua}");
    }

    static void KiemTraSoNT()
    {
        Console.Write("Nhập số nguyên n: ");
        uint n = uint.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
            return;
        }

        for (uint i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
                return;
            }
        }

        Console.WriteLine($"{n} là số nguyên tố.");
    }

    static void KiemTraSoHoanHao()
    {
        Console.Write("Nhập số nguyên n: ");
        uint n = uint.Parse(Console.ReadLine());

        uint sum = 0;
        for (uint i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        if (sum == n)
        {
            Console.WriteLine($"{n} là số hoàn hảo.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số hoàn hảo.");
        }
    }
}
