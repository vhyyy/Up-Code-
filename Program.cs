using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        public int STT { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Tao danh sach hoc sinh
            List<Student> students = new List<Student>
        {
            new Student { STT = 1, Name = "Nguyen Dong Nhat", Age = 16 },
            new Student { STT = 2, Name = "Phung Trong Hung", Age = 17 },
            new Student { STT = 3, Name = "Tieu Viet Huy", Age = 18 },
            new Student { STT = 4, Name = "Nguyen Thanh Dat", Age = 15 },
            new Student { STT = 5, Name = "Ao Van A", Age = 19 }
        };

            // a. In danh sach toan bo hoc sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"STT: {student.STT}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18
            var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            foreach (var student in age15to18)
            {
                Console.WriteLine($"STT: {student.STT}, Name: {student.Name}, Age: {student.Age}");
            }

            // c. Tim va in ra hoc sinh co ten bat dau bang chu "A"
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine($"STT: {student.STT}, Name: {student.Name}, Age: {student.Age}");
            }

            // d. Tinh tong tuoi cua tat ca hoc sinh trong danh sach
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tim va in ra hoc sinh co tuoi lon nhat
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: STT: {oldestStudent.STT}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // f. Sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"STT: {student.STT}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
