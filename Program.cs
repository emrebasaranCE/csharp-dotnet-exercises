using Patika_Linq_Exercise_Repo.DBOperations;
using Patika_Linq_Exercise_Repo.Entities;

namespace Patika_Linq_Exercise_Repo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>;
        }
    }
}
