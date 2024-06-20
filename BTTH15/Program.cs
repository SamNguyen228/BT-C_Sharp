using System;
using System.Text;

class Program
{
    static byte ReadByteInRange(byte min, byte max)
    {
        byte input;
        bool validInput = false;

        do
        {
            Console.Write($"Nhập một số nguyên 1 byte trong khoảng từ {min} đến {max}: ");
            if (byte.TryParse(Console.ReadLine(), out input))
            {
                if (input >= min && input <= max)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"Số nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
            else
            {
                Console.WriteLine("Định dạng không hợp lệ. Vui lòng nhập lại.");
            }
        } while (!validInput);

        return input;
    }

    static float ReadFloat()
    {
        float input;
        bool validInput = false;

        do
        {
            Console.Write("Nhập một số thực 4 byte: ");
            if (float.TryParse(Console.ReadLine(), out input))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Không hợp lệ. Vui lòng nhập lại.");
            }
        } while (!validInput);

        return input;
    }

    static float[] ReadFloatArray(int n)
    {
        float[] array = new float[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = ReadFloat();
        }

        return array;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đọc và in giá trị của số nguyên n 1 byte
        byte n = ReadByteInRange(2, 10);
        Console.WriteLine($"Bạn đã nhập số nguyên n = {n}");

        // Khai báo và cấp phát mảng a
        float[] a = new float[n];

        // Đọc và in giá trị của mảng a
        Console.WriteLine($"Nhập {n} số thực để điền vào mảng a:");
        a = ReadFloatArray(n);

        Console.WriteLine("Giá trị của mảng a bạn đã nhập là:");
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}
