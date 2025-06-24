using Patika_Linq_Exercise_Repo.DBOperations;
using Patika_Linq_Exercise_Repo.Entities;
using System.IO.Compression;
using System.Linq;

namespace Patika_Linq_Exercise_Repo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>;

            // Find
            Console.WriteLine("----- FIND -----");
            // without linq
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
            // with linq
            student = _context.Students.Find(2);
            Console.WriteLine($"{student.Name}");


            // FirstOrDefault()
            Console.WriteLine();
            Console.WriteLine("----- FirstOrDefault -----");
            student = _context.Students.Where(x => x.Surname == "Okyanus").FirstOrDefault();
            Console.WriteLine($"{student.Name}");
            
            student = _context.Students.FirstOrDefault(x => x.Surname == "Okyanus");
            Console.WriteLine($"{student.Name}");

            // SingleOrDefault()
            Console.WriteLine();
            Console.WriteLine("----- SingleOrDefault -----");
            student = _context.Students.Where(x => x.Name == "Mehmet").SingleOrDefault();
            Console.WriteLine($"{student.Name}");
            
            student = _context.Students.SingleOrDefault(x => x.Name == "Ayse");
            Console.WriteLine($"{student.Name}");

            // ToList()
            Console.WriteLine();
            Console.WriteLine("----- ToList -----");
            var student_list = _context.Students.Where(x => x.ClassId == 2).ToList();
            Console.WriteLine($"{student_list.Count}");

            // OrderBy()
            Console.WriteLine();
            Console.WriteLine("----- OrderBy -----");
            student_list = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach (var item in student_list)
            {
                Console.WriteLine($"{item.StudentId} - {item.Name} {item.Surname}");
            }

            // OrderByDescending()
            Console.WriteLine();
            Console.WriteLine("----- OrderByDescending -----");
            student_list = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach (var item in student_list)
            {
                Console.WriteLine($"{item.StudentId} - {item.Name} {item.Surname}");
            }

            // Anonymous Object Result
            Console.WriteLine();
            Console.WriteLine("----- Anonymous Object Result -----");
            var anonymousObject = _context.Students
                                            .Where(x=>x.ClassId == 2)
                                            .Select(x => new {
                                                Id = x.StudentId,
                                                Fullname = x.Name + " " + x.Surname
                                            });

            foreach (var item in anonymousObject)
            {
                Console.WriteLine($"{item.Id} - {item.Fullname}");
            }

        }
    }
}
