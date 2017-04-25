using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() {Name = "Tormund", GradeLevel = 3},
                new Student() {Name = "Ygritte", GradeLevel = 3},
                new Student() {Name = "Tormund", GradeLevel = 2},
            };

            students.Sort();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in {student.GradeLevel}");
            }
        }
    }
}
