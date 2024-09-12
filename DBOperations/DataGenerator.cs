using Patika_Linq_Exercise_Repo.Entities;

namespace Patika_Linq_Exercise_Repo.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                    return;
                
                context.Students.AddRange(
                    new Student()
                    {
                        Name = "Ayse",
                        Surname = "Bir",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "Mehmet",
                        Surname = "Cak",
                        ClassId = 1
                    },
                    new Student()
                    {
                        Name = "Deniz",
                        Surname = "Okyanus",
                        ClassId = 2
                    },
                    new Student()
                    {
                        Name = "Ahmet",
                        Surname = "Caliskan",
                        ClassId = 2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}