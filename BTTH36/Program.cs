using System;
using System.Collections.Generic;
using System.Text;

public abstract class Person
{
    public string Name { get; set; }
    public string Id { get; set; }

    public abstract float Kpi();
}

public interface Kpi
{
    float Kpi();
}

public class Student : Person, Kpi
{
    private string _department;

    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
                _department = value;
            else
                throw new ArgumentException("Department must be 'ICT' or 'ECO'.");
        }
    }

    public override float Kpi()
    {
        // Giả sử điểm GPA của sinh viên là một giá trị ngẫu nhiên.
        Random rand = new Random();
        return (float)(rand.NextDouble() * 4.0); // Điểm GPA từ 0.0 đến 4.0
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        // d. Khai báo obs kiểu Person và gán null
        Person obs = null;

        // e. Cấp phát obs là Student có name là "Nguyễn Tiến Dũng", id là "12345678", department là "ICT". Hiển thị kpi()
        obs = CreateStudent("Nguyễn Tiến Dũng", "12345678", "ICT");
        DisplayKpi(obs);

        // g. Cấp phát obs bị sai về id hoặc department và xem hiệu ứng
        try
        {
            obs = CreateStudent("Nguyễn Tiến Dũng", "12345", "XYZ");
            DisplayKpi(obs);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi tạo sinh viên: {ex.Message}");
        }

        // h. Khai báo các biến danh sách list1, list2 các đối tượng Person
        List<Person> list1 = new List<Person>();
        List<Person> list2 = new List<Person>();

        // Nhập dữ liệu cho list1 và list2 từ bàn phím
        InputStudents(list1, "bàn 1 lớp 23IT5 ngày 25/06/2024");
        InputStudents(list2, "bàn 2 lớp 23IT6 ngày 25/06/2024");

        // Hiển thị list1 và list2
        DisplayStudents("Danh sách sinh viên bàn 1:", list1);
        DisplayStudents("Danh sách sinh viên bàn 2:", list2);

        // k. Khai báo 1 list_list kiểu List của List, và bổ sung list1, list2 vào list_list
        List<List<Person>> list_list = new List<List<Person>> { list1, list2 };

        // Hiển thị list_list
        DisplayListList(list_list);

        // l. Tạo Dictionary dic11 cho list1 Student với trường khóa id và tìm sinh viên có tên là "Nam"
        Dictionary<string, Student> dic11 = CreateDictionary(list1);
        FindStudent(dic11, "Nam");
    }

    // Hàm tạo Student và xử lý exception
    static Student CreateStudent(string name, string id, string department)
    {
        try
        {
            Student student = new Student
            {
                Name = name,
                Id = id,
                Department = department
            };
            return student;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi tạo sinh viên: {ex.Message}");
            return null;
        }
    }

    // Hàm hiển thị Kpi của một Person
    static void DisplayKpi(Person person)
    {
        if (person != null)
        {
            Console.WriteLine($"Kpi của {person.Name}: {person.Kpi()}");
        }
    }

    // Hàm nhập danh sách sinh viên từ bàn phím
    static void InputStudents(List<Person> list, string description)
    {
        Console.WriteLine($"Nhập danh sách sinh viên {description} (kết thúc nhập với @):");
        while (true)
        {
            Console.Write("Tên: ");
            string name = Console.ReadLine();
            if (name == "@") break;

            Console.Write("ID: ");
            string id = Console.ReadLine();

            Console.Write("Department (ICT/ECO): ");
            string department = Console.ReadLine();

            try
            {
                Student student = new Student
                {
                    Name = name,
                    Id = id,
                    Department = department
                };
                list.Add(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm sinh viên: {ex.Message}");
            }
        }
    }

    // Hàm hiển thị danh sách sinh viên
    static void DisplayStudents(string title, List<Person> list)
    {
        Console.WriteLine(title);
        foreach (var person in list)
        {
            Console.WriteLine($"Name: {person.Name}, ID: {person.Id}, Department: {(person as Student)?.Department}, Kpi: {(person as Student)?.Kpi()}");
        }
    }

    // Hàm hiển thị list_list
    static void DisplayListList(List<List<Person>> list_list)
    {
        Console.WriteLine("Danh sách list_list:");
        foreach (var list in list_list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"Name: {person.Name}, ID: {person.Id}, Department: {(person as Student)?.Department}, Kpi: {(person as Student)?.Kpi()}");
            }
        }
    }

    // Hàm tạo Dictionary từ list1 Student
    static Dictionary<string, Student> CreateDictionary(List<Person> list)
    {
        Dictionary<string, Student> dic = new Dictionary<string, Student>();
        foreach (var person in list)
        {
            if (person is Student student)
            {
                dic[student.Id] = student;
            }
        }
        return dic;
    }

    // Hàm tìm sinh viên trong Dictionary theo tên
    static void FindStudent(Dictionary<string, Student> dic, string name)
    {
        Console.WriteLine($"Tìm sinh viên có tên '{name}':");
        foreach (var student in dic.Values)
        {
            if (student.Name == name)
            {
                Console.WriteLine($"Name: {student.Name}, ID: {student.Id}, Department: {student.Department}, Kpi: {student.Kpi()}");
            }
        }
    }
}
