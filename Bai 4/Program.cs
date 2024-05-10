using System;
using System.Collections.Generic;
using System.Xml.Linq;
// Định nghĩa lớp Student
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name; Age = age;
    }
    // Phương thức để hiển thị thông tin sinh viên
    public void DisplayInfo()
    {
        Console.WriteLine("Name:{0},Age{1}",Name,Age);
    }
}
class Program
{
    static void Main()
    {
        // Tạo một List để lưu trữ các đối tượng Student
        List<Student> studentList = new List<Student>();
        Student SD1 = new Student("Alice", 20);
        Student SD2 = new Student("Bob", 22);
        Student SD3 = new Student("Charlie", 21);
        // Thêm các đối tượng Student vào List
        studentList.Add(SD1);
        studentList.Add(SD2);
        studentList.Add(SD3);
        // Duyệt qua List để hiển thị thông tin của các sinh viên
        foreach (var student in studentList)
        {
            student.DisplayInfo();
        }
        Console.ReadLine();
    }
}