
using AutoMapper;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.GetBooks
{
    public class GetBookQuery
    {
        private readonly BookStorageDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetBookQuery(BookStorageDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<BooksViewModel> Handle()
        {
            var bookslist = _dbContext.Books.OrderBy(x => x.Id).ToList();
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookslist); 
            return vm;
        }
    }

    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}