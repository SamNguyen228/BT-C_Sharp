using System;
using System.Text;

class Program
{
    // Hàm để đọc số nguyên 1 byte từ bàn phím và kiểm tra điều kiện
    static byte ReadByteFromConsole(string prompt, byte min, byte max)
    {
        byte value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            isValidInput = byte.TryParse(Console.ReadLine(), out value);
            if (!isValidInput || value < min || value > max)
            {
                Console.WriteLine($"Giá trị nhập vào không hợp lệ. Vui lòng nhập lại số từ {min} đến {max}.");
                isValidInput = false;
            }
        } while (!isValidInput);

        return value;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Gọi hàm ReadByteFromConsole để nhập giá trị n
        byte n = ReadByteFromConsole("Nhập vào số nguyên từ 2 đến 10 (1 byte không dấu): ", 2, 10);

        // In giá trị n đã nhập ra màn hình
        Console.WriteLine($"Bạn đã nhập số nguyên 1 byte không dấu là: {n}");

        // Dừng màn hình console để người dùng có thể nhìn thấy kết quả trước khi đóng cửa sổ
        Console.WriteLine("Nhấn phím bất kỳ để đóng chương trình...");
        Console.ReadKey();
    }
}
