using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name {get; set;}
    public int Grade {get; set;}
    public int Age {get; set;}
}
class Task4
{
    public static void Run()
    {
        List<Student> students = new List<Student>()
        {
            new Student {Name = "Aayush",Grade = 85,Age = 21},
            new Student {Name = "Raju",Grade = 72,Age = 20},
        };

        Console.Write("Enter minimum grade:");

        int minGrade;
        int.TryParse(Console.ReadLine(),out minGrade);

        var filteredStudents = students.Where(s => s.Grade > minGrade).OrderBy(s => s.Name);

        Console.WriteLine("\nFiltered and Sorted Students:\n");

        foreach (var s in filteredStudents)
        {
            Console.WriteLine("Name: " + s.Name +",Grade: " + s.Grade +",Age: " + s.Age);
        }
    }
}