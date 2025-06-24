using AutoMapper;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.CreateBook
{
    public class CreateBookCommand
    {
        public CreateBookModel model { get; set; }
        private readonly BookStorageDBContext _dbContext;
        private readonly IMapper _mapper;

        public CreateBookCommand(BookStorageDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Title == model.Title);
            if (book is not null)
                throw new InvalidOperationException("Book is already exists!");
            
            book = _mapper.Map<Book>(model); 
            _dbContext.Books.Add(book);
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