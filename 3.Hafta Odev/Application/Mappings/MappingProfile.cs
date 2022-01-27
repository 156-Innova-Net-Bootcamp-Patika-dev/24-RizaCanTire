using Application.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();

            CreateMap<Author, BookDto>();
            CreateMap<BookDto, Author>();

            CreateMap<Category, BookDto>();
            CreateMap<BookDto, Category>();

            CreateMap<BookAddDto, Book>();
            CreateMap<Book, BookAddDto>();

            CreateMap<BookUpdateDto, Book>();
            CreateMap<Book, BookUpdateDto>();

            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorDto>().ReverseMap();

            CreateMap<Author, AuthorUpdateDto>();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();

            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();





        }
    }
}
