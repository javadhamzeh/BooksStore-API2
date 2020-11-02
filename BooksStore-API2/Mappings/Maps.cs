using AutoMapper;
using BooksStore_API2.Data;
using BooksStore_API2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore_API2.Mappings
{
    public class Maps :Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
