using System;
using System.Threading;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một luồng mới để chạy hàm ff
            Thread thread = new Thread(new ThreadStart(ff));
            thread.Start();

            // Đợi cho luồng hoàn thành
            thread.Join();

            // Hiển thị thông báo khi luồng kết thúc
            Console.WriteLine("Đã thực hiện xong");
            Console.ReadLine();
        }

        public static void ff()
        {
            Random random = new Random();
            while (true)
            {
                int n = random.Next(0, 100000);
                if (n % 2025 == 0)
                {
                    break;
                }
                Console.WriteLine(n);
                Thread.Sleep(100); // Delay 100ms
            }
        }
    }
}
