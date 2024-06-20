using System;
using System.Globalization;
using System.Text;

class Program
{
    // Hàm để đọc số thực 4 byte từ bàn phím và kiểm tra điều kiện
    static float ReadFloatFromConsole(string prompt)
    {
        float value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            isValidInput = float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out value);
            if (!isValidInput)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại!.");
            }
        } while (!isValidInput);

        return value;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Gọi hàm ReadFloatFromConsole để nhập giá trị x
        float a = ReadFloatFromConsole("Nhập vào số thực (4 byte): ");

        // In giá trị x đã nhập ra màn hình
        Console.WriteLine($"Bạn đã nhập số thực 4 byte là: {a}");

        // Dừng màn hình console để người dùng có thể nhìn thấy kết quả trước khi đóng cửa sổ
        Console.WriteLine("Nhấn phím bất kỳ để đóng chương trình...");
        Console.ReadKey();
    }
}
