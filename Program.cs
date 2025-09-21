using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentCode
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(string name) => Name = name;

        public void AddGrade(int grade) => Grades.Add(grade);

        public double GetAverageGrade() => Grades.Count > 0 ? Grades.Average() : 0.0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            while (true)
            {
                Console.Write("Enter student name (or done to stop): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                    break;

                var student = new Student(name);

                while (true)
                {
                    Console.Write($"Enter grade for {name} (or -1 to stop): ");
                    int grade = int.Parse(Console.ReadLine());

                    if (grade == -1)
                        break;

                    student.AddGrade(grade);
                }

                students.Add(student);
            }

            Console.WriteLine("\nClassroom Summary:");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} - Average Grade: {s.GetAverageGrade():F1}");
            }
        }
    }
}