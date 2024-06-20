using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo một Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm một số cặp key-giá trị vào Hashtable
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add(3, "Three");
        hashtable.Add("four", 4);
        hashtable.Add("five", 5.0);

        // Sử dụng switch-case để chọn chức năng
        while (true)
        {
            Console.WriteLine("*********** Chọn một lựa chọn ***********");
            Console.WriteLine("        1. Kiểm tra key");
            Console.WriteLine("        2. Kiểm tra giá trị");
            Console.WriteLine("        3. Truy xuất giá trị bằng key");
            Console.WriteLine("        4. In tất cả các key");
            Console.WriteLine("        5. In tất cả các giá trị");
            Console.WriteLine("        6. Thoát");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nhập key cần kiểm tra: ");
                    string keyToCheck = Console.ReadLine();
                    if (hashtable.ContainsKey(keyToCheck))
                    {
                        Console.WriteLine($"Key '{keyToCheck}' tồn tại trong Hashtable.");
                    }
                    else
                    {
                        Console.WriteLine($"Key '{keyToCheck}' không tồn tại trong Hashtable.");
                    }
                    break;

                case "2":
                    Console.Write("Nhập giá trị cần kiểm tra: ");
                    string valueToCheck = Console.ReadLine();
                    if (hashtable.ContainsValue(valueToCheck))
                    {
                        Console.WriteLine($"Giá trị '{valueToCheck}' tồn tại trong Hashtable.");
                    }
                    else
                    {
                        Console.WriteLine($"Giá trị '{valueToCheck}' không tồn tại trong Hashtable.");
                    }
                    break;

                case "3":
                    Console.Write("Nhập key để truy xuất giá trị: ");
                    string keyToRetrieve = Console.ReadLine();
                    if (hashtable.ContainsKey(keyToRetrieve))
                    {
                        Console.WriteLine($"Giá trị tương ứng với key '{keyToRetrieve}' là '{hashtable[keyToRetrieve]}'.");
                    }
                    else
                    {
                        Console.WriteLine($"Key '{keyToRetrieve}' không tồn tại trong Hashtable.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Tất cả các key trong Hashtable:");
                    foreach (var key in hashtable.Keys)
                    {
                        Console.WriteLine(key);
                    }
                    break;

                case "5":
                    Console.WriteLine("Tất cả các giá trị trong Hashtable:");
                    foreach (var value in hashtable.Values)
                    {
                        Console.WriteLine(value);
                    }
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
}
