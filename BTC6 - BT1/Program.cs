using System;
using System.IO;
using System.Text;

class Program
{
    // Khai báo biến chuỗi không đổi là "FilePath" và gán giá trị là "data.txt"
    const string FilePath = "data.txt";

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Gọi phương thức "CreateFile" với hằng số "FilePath"
        CreateFile(FilePath);

        // Gọi phương thức "WriteToFile" với hằng số "FilePath" và nội dung mẫu
        string content1 = "Đây là nội dung mẫu: Hello World!";
        WriteToFile(FilePath, content1);

        // Gọi phương thức "ReadFromFile" với hằng số "FilePath"
        ReadFromFile(FilePath);

        // Gọi phương thức "AppendToFile" với hằng số "FilePath" và nội dung mẫu khác
        string content2 = "\nĐây là nội dung được thêm vào: Xin Chao Cac Ban!";
        AppendToFile(FilePath, content2);

        // Gọi lại phương thức "ReadFromFile" với hằng số "FilePath"
        ReadFromFile(FilePath);

        // Gọi phương thức "DeleteFile" với hằng số "FilePath"
        DeleteFile(FilePath);

        Console.WriteLine("\nChương trình đã thực thi xong. Kiểm tra tệp tin để xác nhận kết quả.");
    }

    // Phương thức tạo tệp tin mới tại đường dẫn đã cho
    static void CreateFile(string filePath)
    {
        using (File.Create(filePath)) { }
        Console.WriteLine($"Đã tạo tệp tin mới tại: {filePath}");
    }

    // Phương thức ghi nội dung vào tệp tin đã cho
    static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine($"Đã ghi nội dung vào tệp tin: {filePath}");
    }

    // Phương thức đọc nội dung từ tệp tin đã cho và in ra màn hình
    static void ReadFromFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"\nNội dung của tệp tin {filePath}:");
        Console.WriteLine(content);
    }

    // Phương thức nối thêm nội dung vào tệp tin đã cho
    static void AppendToFile(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
        Console.WriteLine($"\nĐã nối thêm nội dung vào tệp tin: {filePath}");
    }

    // Phương thức xóa tệp tin đã cho
    static void DeleteFile(string filePath)
    {
        File.Delete(filePath);
        Console.WriteLine($"Đã xóa tệp tin: {filePath}");
    }
}
