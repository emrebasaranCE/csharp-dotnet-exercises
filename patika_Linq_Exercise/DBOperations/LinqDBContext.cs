using Microsoft.EntityFrameworkCore;
using Patika_Linq_Exercise_Repo.Entities;

namespace Patika_Linq_Exercise_Repo.DBOperations
{
    public class LinqDbContext : DbContext
    {
        public DbSet<Student> Students{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
        }
    }
}