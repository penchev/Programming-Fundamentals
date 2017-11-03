using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < number; i++)
            {
                Student student = new Student();
                string input = Console.ReadLine();
                string[] inputArgs = input.Split(' ');
                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            students.Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}"));
                
        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set;}
            public double AverageGrade => Grades.Average();

        }
    }
}
