using BookStoreWebapi.DBOperations;
using FluentValidation;

namespace BookStoreWebapi.BookOperations.DeleteBook
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator() 
        {
            RuleFor(command => command.BookId).GreaterThan(0);
        }
    }
}