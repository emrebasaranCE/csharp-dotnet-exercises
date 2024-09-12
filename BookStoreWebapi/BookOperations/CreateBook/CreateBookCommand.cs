using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.CreateBook
{
    public class CreateBookCommand
    {
        public CreateBookModel model { get; set; }
        private readonly BookStorageDBContext _dbContext;

        public CreateBookCommand(BookStorageDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Title == model.Title);
            if (book is not null)
                throw new InvalidOperationException("Book is already exists!");
            
            book = new Book();
            book.Title = model.Title;
            book.PublishDate = model.PublishDate;
            book.PageCount = model.PageCount;
            book.GenreId = model.GenreId;

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            _dbContext.SaveChanges();
        }
    }

    public class CreateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}