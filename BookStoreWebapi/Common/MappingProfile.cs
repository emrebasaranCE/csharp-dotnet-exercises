using AutoMapper;
using BookStoreWebapi.BookOperations.CreateBook;
using BookStoreWebapi.BookOperations.GetBooks;
using BookStoreWebapi.BookOperations.UpdateBook;

namespace BookStoreWebapi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            // map this = CreateBookModel to this => Book 

            //CreateMap<BooksViewModel, Book>();
            CreateMap<Book, BooksViewModelWithId>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));
            CreateMap<UpdateBookModel, Book>();

            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));
        }
    }
}