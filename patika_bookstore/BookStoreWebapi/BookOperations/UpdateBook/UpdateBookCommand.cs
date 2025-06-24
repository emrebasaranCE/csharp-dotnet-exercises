
using System.Reflection.Metadata;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.UpdateBook
{
    public class UpdateBookCommand
    {
        public UpdateBookModel model {get; set;}
        public int BookId { get; set; }
        private readonly BookStorageDBContext _dbcontext;

        public UpdateBookCommand(BookStorageDBContext context)
        {
            _dbcontext = context;
        }

        public void Handle()
        {
            var book = _dbcontext.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {BookId}!");
            
            book.GenreId = model.GenreId != default ? model.GenreId : book.GenreId;
            book.Title = model.Title != default ? model.Title : book.Title;

            _dbcontext.SaveChanges();
        }
    }

    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}