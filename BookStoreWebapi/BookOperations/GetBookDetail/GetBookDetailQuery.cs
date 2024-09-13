
using System.Runtime.Intrinsics.X86;
using AutoMapper;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStorageDBContext _dbcontext; 
        private readonly IMapper _mapper;

        public GetBookDetailQuery(BookStorageDBContext context, IMapper mapper)
        {
            _dbcontext = context;
            _mapper = mapper;
        }

        public BooksDetailedViewModel Handle(int id)
        {
            var book = _dbcontext.Books.Where(book => book.Id == id).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            BooksDetailedViewModel vm = _mapper.Map<BooksDetailedViewModel>(book); 
            return vm;
        }
    }

    public class BooksDetailedViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}