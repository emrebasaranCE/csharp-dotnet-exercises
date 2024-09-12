using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebapi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
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
                Id = 43,
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

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book => book.Id == id).SingleOrDefault();
            return book;
        }

        // [HttpGet]
        // public Book Get([FromQuery] string id)
        // {
        //     var book = BookList.Where(book => book.Id == Convert.ToInt16(id)).SingleOrDefault();
        //     return book;
        // }

        // Post
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(x => x.Id == newBook.Id);
            if (book is not null)
                return BadRequest();
            
            BookList.Add(newBook);
            return Ok();
        }

        // Put
        [HttpPut("{id}")]

        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = BookList.SingleOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();
            
            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;

            return Ok();
        }

        // Delete

        [HttpDelete("{id}")]

        public IActionResult DeleteBook(int id)
        {
            var book = BookList.SingleOrDefault(x => x.Id == id);
            
            if (book is null)
                return BadRequest();
            
            BookList.Remove(book);
            return Ok();
        }
    }
}
