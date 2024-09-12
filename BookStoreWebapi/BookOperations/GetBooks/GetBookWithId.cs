
using System.Runtime.Intrinsics.X86;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.GetBooks
{
    public class GetBookWithId
    {
        private readonly BookStorageDBContext _context; 

        public GetBookWithId(BookStorageDBContext context)
        {
            _context = context;
        }

        public BooksViewModelWithId Handle(int id)
        {
            var book = _context.Books.Where(book => book.Id == id).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            BooksViewModelWithId vm = new BooksViewModelWithId();
            vm.Title = book.Title;
            vm.PageCount = book.PageCount;
            vm.PublishDate = book.PublishDate.Date.ToString("dd/mm/yyyy");
            vm.Genre = ((GenreEnum)book.GenreId).ToString();

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