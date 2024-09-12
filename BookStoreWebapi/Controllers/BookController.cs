using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book{
                Id = 1,
                Title = "The Great Gatsby",
                GenreId = 1,
                PageCount = 180,
                PublishDate = new DateTime(1925, 4, 10)
            },
            new Book{
                Id = 2,
                Title = "Sherlock Holmes",
                GenreId = 1,
                PageCount = 123,
                PublishDate = new DateTime(1950, 2, 5)
            },
            new Book{
                Id = 3,
                Title = "Dune",
                GenreId = 1,
                PageCount = 450,
                PublishDate = new DateTime(2000, 12, 15)
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookslist = BookList.OrderBy(x => x.Id).ToList();
            return bookslist;
        }

    }
}
