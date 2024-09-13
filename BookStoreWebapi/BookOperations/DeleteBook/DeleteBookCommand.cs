using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStorageDBContext _dbcontext; 

        public DeleteBookCommand(BookStorageDBContext context)
        {
            _dbcontext = context;
        }

        public void Handle(int id)
        {
            var book = _dbcontext.Books.SingleOrDefault(x => x.Id == id);
            
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            _dbcontext.Books.Remove(book);
            _dbcontext.SaveChanges();
        }
    }
}