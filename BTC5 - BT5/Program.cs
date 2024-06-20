using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Chương trình thực hiện cấu trúc dữ liệu ngăn xếp");

        while (true)
        {
            Console.WriteLine("\nChọn loại dữ liệu để sử dụng với ngăn xếp:");
            Console.WriteLine("1. Số nguyên");
            Console.WriteLine("2. Chuỗi");
            Console.WriteLine("0. Thoát");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
            {
                Console.WriteLine("Vui lòng nhập lại lựa chọn hợp lệ.");
            }

            if (choice == 0)
            {
                break;
            }

            switch (choice)
            {
                case 1:
                    TestIntegerStack();
                    break;
                case 2:
                    TestStringStack();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        Console.WriteLine("\nKết thúc chương trình.");
    }

    static void TestIntegerStack()
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");

        try
        {
            Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }

    static void TestStringStack()
    {
        MyStack<string> stack = new MyStack<string>();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");

        try
        {
            Console.WriteLine($"Phần tử trên cùng là: {stack.Pop()}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}

public class MyStack<T>
{
    private List<T> elements = new List<T>();

    public void Push(T item)
    {
        elements.Add(item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp trống.");
        }

        T top = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return top;
    }
}
