using System;
using System.Collections.Generic;
using System.IO;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string csvFilePath = "students.csv";

        // Đọc dữ liệu từ tệp CSV
        List<Student> students = ReadStudentsFromCsv(csvFilePath);

        // Hiển thị danh sách học sinh
        DisplayStudents(students);

        // Ghi danh sách học sinh vào tệp CSV mới
        string newCsvFilePath = "new_students.csv";
        WriteStudentsToCsv(newCsvFilePath, students);
    }

    public static List<Student> ReadStudentsFromCsv(string csvFilePath)
    {
        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(csvFilePath))
        {
            // Bỏ qua tiêu đề (nếu có)
            reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    Student student = new Student
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Age = int.Parse(parts[2]),
                        Grade = double.Parse(parts[3])
                    };
                    students.Add(student);
                }
            }
        }

        return students;
    }

    public static void WriteStudentsToCsv(string csvFilePath, List<Student> students)
    {
        using (StreamWriter writer = new StreamWriter(csvFilePath))
        {
            // Ghi tiêu đề
            writer.WriteLine("Id,Name,Age,Grade");

            // Ghi từng dòng dữ liệu
            foreach (Student student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Grade}");
            }
        }
    }

    public static void DisplayStudents(List<Student> students)
    {
        Console.WriteLine("Danh sách học sinh:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
    }
}