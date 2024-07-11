using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khởi tạo một Dictionary mới
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm các phần tử vào Dictionary
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);

        // In ra các phần tử trong Dictionary
        foreach (KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
/* Trong đoạn mã sử dụng biến kiểu Dictionary, key là phần tử đầu tiên trong mỗi cặp key-value của từ điển. 
Trong trường hợp này, key được định nghĩa là kiểu string, và được sử dụng để định danh và truy cập các giá trị trong Dictionary. */  