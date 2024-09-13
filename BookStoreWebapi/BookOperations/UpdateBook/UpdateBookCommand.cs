
using System.Reflection.Metadata;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi.BookOperations.UpdateBook
{
    public class UpdateBookCommand
    {
        public UpdateBookModel model {get; set;}
        private readonly BookStorageDBContext _dbcontext;

        public UpdateBookCommand(BookStorageDBContext context)
        {
            _dbcontext = context;
        }

        public void Handle(int id)
        {
            var book = _dbcontext.Books.SingleOrDefault(x => x.Id == id);
            if (book is null)
                throw new InvalidOperationException($"Book doesn't exists with this id: {id}!");
            
            book.GenreId = model.GenreId != default ? model.GenreId : book.GenreId;
            book.PageCount = model.PageCount != default ? model.PageCount : book.PageCount;
            book.PublishDate = model.PublishDate != default ? model.PublishDate : book.PublishDate;
            book.Title = model.Title != default ? model.Title : book.Title;

            _dbcontext.SaveChanges();
        }
    }

    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}