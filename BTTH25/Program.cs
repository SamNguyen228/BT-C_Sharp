using System;
using System.Collections.Generic;
using System.Text;

// Lớp trừu tượng Person
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    protected string BankAccount { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public abstract string GetRole();
}

// Interface IKPIEvaluator
interface IKPIEvaluator
{
    double CalculateKPI();
}

// Lớp TeachingAssistant
class TeachingAssistant : Person, IKPIEvaluator
{
    public string EmployeeID { get; set; }
    private int NumberOfCourses { get; set; }

    public TeachingAssistant(string name, int age, string gender, string employeeID, int numberOfCourses)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        NumberOfCourses = numberOfCourses;
    }

    public override string GetRole()
    {
        return "Trợ lý giảng dạy";
    }

    public double CalculateKPI()
    {
        return NumberOfCourses * 5;
    }
}

// Lớp Lecturer
class Lecturer : Person, IKPIEvaluator
{
    public string EmployeeID { get; set; }
    private int NumberOfPublications { get; set; }

    public Lecturer(string name, int age, string gender, string employeeID, int numberOfPublications)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        NumberOfPublications = numberOfPublications;
    }

    public override string GetRole()
    {
        return "Giảng viên";
    }

    public double CalculateKPI()
    {
        return NumberOfPublications * 7;
    }
}

// Lớp Professor
sealed class Professor : Lecturer
{
    public static int CountProfessors = 0;
    private int NumberOfProjects { get; set; }

    public Professor(string name, int age, string gender, string employeeID, int numberOfPublications, int numberOfProjects)
        : base(name, age, gender, employeeID, numberOfPublications)
    {
        NumberOfProjects = numberOfProjects;
        CountProfessors++;
    }

    public override string GetRole()
    {
        return "Giáo sư";
    }

    public double CalculateKPI()
    {
        return base.CalculateKPI() + (NumberOfProjects * 10);
    }
}

// Lớp Program
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<Person> persons = new List<Person>();
        int n;

        // Nhập số lượng đối tượng
        do
        {
            Console.Write("Nhập số lượng đối tượng: ");

        } while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10);

        // Nhập đối tượng
        for (int i = 0; i < n; i++)
        {
            Person person = null;
            string type;

            do
            {
                Console.Write("Nhập loại đối tượng (ta, lec, gs): ");
                type = Console.ReadLine().ToLower();

                switch (type)
                {
                    case "ta":
                        person = CreateTeachingAssistant();
                        break;
                    case "lec":
                        person = CreateLecturer();
                        break;
                    case "gs":
                        person = CreateProfessor();
                        break;
                }
            } while (person == null);

            persons.Add(person);
        }

        // Hiển thị đối tượng
        DisplayPersons(persons);

        // Hiển thị số lượng Giáo sư
        Console.WriteLine($"Số lượng Giáo sư: {Professor.CountProfessors}");
    }

    static TeachingAssistant CreateTeachingAssistant()
    {
        Console.Write("Nhập tên: ");
        string name = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập tuổi: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");
        Console.Write("Nhập giới tính: ");
        string gender = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập mã nhân viên: ");
        string employeeID = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập số lượng khóa học: ");
        int numberOfCourses = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");

        return new TeachingAssistant(name, age, gender, employeeID, numberOfCourses);
    }

    static Lecturer CreateLecturer()
    {
        Console.Write("Nhập tên: ");
        string name = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập tuổi: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");
        Console.Write("Nhập giới tính: ");
        string gender = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập mã nhân viên: ");
        string employeeID = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập số lượng ấn phẩm: ");
        int numberOfPublications = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");

        return new Lecturer(name, age, gender, employeeID, numberOfPublications);
    }

    static Professor CreateProfessor()
    {
        Console.Write("Nhập tên: ");
        string name = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập tuổi: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");
        Console.Write("Nhập giới tính: ");
        string gender = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập mã nhân viên: ");
        string employeeID = Console.ReadLine();
        Console.WriteLine("------------------");
        Console.Write("Nhập số lượng ấn phẩm: ");
        int numberOfPublications = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");
        Console.Write("Nhập số lượng dự án: ");
        int numberOfProjects = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------");

        return new Professor(name, age, gender, employeeID, numberOfPublications, numberOfProjects);
    }

    static void DisplayPersons(List<Person> persons)
    {
        foreach (var person in persons)
        {
            IKPIEvaluator evaluator = person as IKPIEvaluator;
            Console.WriteLine("***************==  THÔNG TIN  ==*****************");
            Console.WriteLine($"Tên: {person.Name}, Vai trò: {person.GetRole()}, KPI: {evaluator?.CalculateKPI()}");

            Console.WriteLine("-------------------------------------------------");
        }
    }
}