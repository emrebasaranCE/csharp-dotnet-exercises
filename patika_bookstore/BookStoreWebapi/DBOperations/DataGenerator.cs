using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreWebapi.DBOperations;
using Microsoft.EntityFrameworkCore.Internal;

namespace BookStoreWebapi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStorageDBContext(serviceProvider.GetRequiredService<DbContextOptions<BookStorageDBContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        // Id = 1,
                        Title = "The Great Gatsby",
                        GenreId = 1,
                        PageCount = 180,
                        PublishDate = new DateTime(1925, 4, 10)
                    },
                    new Book
                    {
                        // Id = 43,
                        Title = "Sherlock Holmes",
                        GenreId = 1,
                        PageCount = 123,
                        PublishDate = new DateTime(1950, 2, 5)
                    },
                    new Book
                    {
                        // Id = 3,
                        Title = "Dune",
                        GenreId = 2,
                        PageCount = 450,
                        PublishDate = new DateTime(2000, 12, 15)
                    });
                context.SaveChanges();
                }
            }
        }
    }
