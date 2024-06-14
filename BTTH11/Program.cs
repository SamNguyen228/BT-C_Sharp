using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập nội dung cần ghi vào file: ");
        string content = Console.ReadLine();

        Console.Write("Nhập tên file: ");
        string fileName = Console.ReadLine();

        // Ghi nội dung vào file
        WriteToFile(fileName, content);

        // Đọc nội dung từ file và hiển thị lên màn hình
        string fileContent = ReadFromFile(fileName);
        Console.Write("\nNội dung trong file: ");
        Console.WriteLine(fileContent);

        Console.ReadLine();
    }

    static void WriteToFile(string fileName, string content)
    {
        try
        {
            // Mở file để ghi
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Ghi nội dung vào file
                writer.WriteLine(content);
            }
            Console.WriteLine("Ghi vào file thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi vào file: {ex.Message}");
        }
    }

    static string ReadFromFile(string fileName)
    {
        try
        {
            // Mở file để đọc
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Đọc nội dung từ file
                string content = reader.ReadToEnd();
                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            return null;
        }
    }
}
