using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStorageDBContext _context; 

        public DeleteBookCommand(BookStorageDBContext context)
        {
            _context = context;
        }

        public void Handle(int id)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == id);
            
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}