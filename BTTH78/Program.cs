using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Phần sử dụng Thread
        var thread = new Thread(() =>
        {
            Console.WriteLine("Thread bắt đầu.");
            Thread.Sleep(5000); // Tạm dừng thread trong 1 giây
            Console.WriteLine("Thread kết thúc.");
        });

        thread.Start();
        thread.Join(); // Đợi thread hoàn thành

        // Phần sử dụng async/await
        await Async1(); // Gọi hàm async
    }

    public static async Task Async1()
    {
        Console.WriteLine("Async bắt đầu.");
        await Task.Delay(10000); // Tạm dừng không đồng bộ trong 1 giây
        Console.WriteLine("Async kết thúc.");
    }
}
