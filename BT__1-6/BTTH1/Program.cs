using System;
using System.Text;

namespace BTTH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("-------------- Chọn một tùy chọn: ---------------");
                Console.WriteLine("**************************************************");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    1. Thực hiện các phép toán trên số nguyên   *");
                Console.WriteLine("*    2. Tính tổng các phần tử trong mảng         *");
                Console.WriteLine("*    3. Đảo ngược số nguyên không dấu            *");
                Console.WriteLine("*                 4. Thoát                       *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("**************************************************");

                Console.Write("Nhập Lựa Chọn Của Bạn: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ThucHienPhepToanNguyen();
                        break;
                    case "2":
                        TinhTongCacPhanTuMang();
                        break;
                    case "3":
                        DaoNguocSoNguyen();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số từ 1 đến 4.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                }
            } while (!exit);
        }

        static void ThucHienPhepToanNguyen()
        {
            bool nhapHopLe = false;
            do
            {
                try
                {
                    Console.WriteLine("----- Thực Hiện Các Phép Toán Trên Số Nguyên -----");
                    Console.Write("Nhập số nguyên a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên b: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Tổng của a và b: {a + b}");
                    Console.WriteLine($"Hiệu của a và b: {a - b}");
                    Console.WriteLine($"Tích của a và b: {a * b}");

                    if (b != 0)
                    {
                        Console.WriteLine($"Thương nguyên của a và b: {a / b}");
                        Console.WriteLine($"Thương thực của a và b: {(double)a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Lỗi: Không thể chia cho 0.");
                    }

                    nhapHopLe = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập lại.");
                }
            } while (!nhapHopLe);
        }

        static void TinhTongCacPhanTuMang()
        {
            Console.WriteLine("----- Tính Tổng Các Phần Tử Trong Mảng -----");
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                tong += arr[i];
            }

            Console.WriteLine($"Tổng các phần tử trong mảng: {tong}");
        }

        static void DaoNguocSoNguyen()
        {
            Console.WriteLine("----- Đảo Ngược Số Nguyên Không Dấu -----");
            Console.Write("Nhập số nguyên không dấu: ");
            uint num = uint.Parse(Console.ReadLine());
            uint soDaoNguoc = 0;

            while (num > 0)
            {
                soDaoNguoc = soDaoNguoc * 10 + (num % 10);
                num /= 10;
            }

            Console.WriteLine($"Số đảo ngược: {soDaoNguoc}");
        }
    }
}
