

using System.Reflection.Metadata;
using BookStoreWebapi.Common;
using BookStoreWebapi.DBOperations;
using FluentValidation;

namespace BookStoreWebapi.BookOperations.UpdateBook
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.model.GenreId).GreaterThan(0);
            RuleFor(command => command.model.Title).NotEmpty().MinimumLength(3);
        }
    }
}