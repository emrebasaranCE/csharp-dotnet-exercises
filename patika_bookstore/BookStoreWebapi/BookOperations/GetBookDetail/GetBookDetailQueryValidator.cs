using FluentValidation;

namespace BookStoreWebapi.BookOperations.GetBookDetail
{
    public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
    {
        public GetBookDetailQueryValidator()
        {
            RuleFor(command => command.Book_Id).GreaterThan(0);
        }
    }
}