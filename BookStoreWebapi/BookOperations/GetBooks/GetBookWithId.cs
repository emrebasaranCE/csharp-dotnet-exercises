
using System.Runtime.Intrinsics.X86;
using AutoMapper;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.GetBooks
{
    public class GetBookWithId
    {
        private readonly BookStorageDBContext _dbcontext; 
        private readonly IMapper _mapper;

        public GetBookWithId(BookStorageDBContext context, IMapper mapper)
        {
            _dbcontext = context;
            _mapper = mapper;
        }

        public BooksViewModelWithId Handle(int id)
        {
            var book = _dbcontext.Books.Where(book => book.Id == id).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            BooksViewModelWithId vm = _mapper.Map<BooksViewModelWithId>(book); 
            return vm;
        }
    }

    public class BooksViewModelWithId
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}