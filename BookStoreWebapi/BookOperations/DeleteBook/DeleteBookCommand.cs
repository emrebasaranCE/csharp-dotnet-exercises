using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStorageDBContext _dbcontext;

        public int BookId { get; set; }
        public DeleteBookCommand(BookStorageDBContext context)
        {
            _dbcontext = context;
        }

        public void Handle()
        {
            var book = _dbcontext.Books.SingleOrDefault(x => x.Id == BookId);
            
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {BookId}!");
            
            _dbcontext.Books.Remove(book);
            _dbcontext.SaveChanges();
        }
    }
}